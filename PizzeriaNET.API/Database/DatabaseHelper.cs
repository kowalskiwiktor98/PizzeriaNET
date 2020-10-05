using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Npgsql;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Database
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly ILogger<DatabaseHelper> _logger;

        public DatabaseHelper(ILogger<DatabaseHelper> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<MenuItems>> GetMenuItems()
        {
            _logger.LogInformation("Begin GetMenuItems");
            var menuItems = new List<MenuItems>();
            try
            {
                await using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable("connectionString")))
                await using (var command = new NpgsqlCommand("selectitems", connection))
                {
                    await connection.OpenAsync();
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("date", NpgsqlTypes.NpgsqlDbType.Timestamp);
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            menuItems.Add(new MenuItems()
                            {
                                Name = (string)reader[0],
                                Category = (string)reader[1],
                                Price = Convert.ToSingle(reader[2])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return menuItems;
        }

        public async Task InsertOrder(PlaceOrderRequest placeOrderRequest)
        {
            _logger.LogInformation("Begin InsertOrder");
            try
            {
                await using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable("connectionString")))
                {
                    await connection.OpenAsync();
                    int newOrderID = -1;
                    await using (var command = new NpgsqlCommand("insertorder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("email", NpgsqlTypes.NpgsqlDbType.Varchar, placeOrderRequest.Email);
                        command.Parameters.AddWithValue("comment", NpgsqlTypes.NpgsqlDbType.Text, placeOrderRequest.Comment);
                        command.Parameters.AddWithValue("date", NpgsqlTypes.NpgsqlDbType.Timestamp, placeOrderRequest.OrderTime);
                        await using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                newOrderID = (int)reader[0];
                            }
                        }
                    }

                    if (newOrderID < 0) throw new Exception("Bad order id");

                    foreach (var orderItem in placeOrderRequest.OrderedItems)
                    {
                        await using (var command = new NpgsqlCommand("insertorderitem", connection))
                        {
                            //FFS WHY THIS SHIT DOESN'T WORK LIKE IT SHOULD
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("name", NpgsqlTypes.NpgsqlDbType.Varchar, orderItem.Name);
                            command.Parameters.AddWithValue("quantity", NpgsqlTypes.NpgsqlDbType.Integer, orderItem.Quantity);
                            command.Parameters.AddWithValue("orderid", NpgsqlTypes.NpgsqlDbType.Integer, newOrderID);
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task<IEnumerable<OrderHistoryEntry>> SelectOrderHistory(string email)
        {
            _logger.LogInformation("Begin SelectOrderHistory");
            var orderHistory = new List<OrderHistoryEntry>();
            try
            {
                await using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable("connectionString")))
                await using (var command = new NpgsqlCommand("selectorderhistory", connection))
                {
                    await connection.OpenAsync();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_email", NpgsqlTypes.NpgsqlDbType.Text, email);
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        //TODO: Add reading order history
                        while (await reader.ReadAsync())
                        {
                            orderHistory.Add(new OrderHistoryEntry()
                            {
                                OrderID = (int)reader[0],
                                Item = (string)reader[1],
                                Quantity = (int)reader[2],
                                Price = Convert.ToSingle(reader[3])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return orderHistory;
        }
    }
}
