using Microsoft.Extensions.Logging;
using Npgsql;
using PizzeriaNET.API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Threading.Tasks;

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
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            menuItems.Add(new MenuItems()
                            {
                                ID = (int)reader[0],
                                Name = (string)reader[1],
                                Category = (string)reader[2],
                                Price = Convert.ToSingle(reader[3])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SocketException) _logger.LogError("Could not connect to Database");
                _logger.LogError(ex.Message);
            }

            return menuItems;
        }

        public async Task<IEnumerable<OrderHistoryDB>> InsertOrder(PlaceOrderRequest placeOrderRequest)
        {
            _logger.LogInformation("Begin InsertOrder");
            var newOrder = new List<OrderHistoryDB>();
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
                            command.Parameters.AddWithValue("itemid", NpgsqlTypes.NpgsqlDbType.Integer, orderItem.ItemID);
                            command.Parameters.AddWithValue("quantity", NpgsqlTypes.NpgsqlDbType.Integer, orderItem.Quantity);
                            command.Parameters.AddWithValue("orderid", NpgsqlTypes.NpgsqlDbType.Integer, newOrderID);
                            await command.ExecuteNonQueryAsync();
                        }
                    }

                    await using (var command = new NpgsqlCommand("selectinsertedorder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("_id", NpgsqlTypes.NpgsqlDbType.Integer, newOrderID);
                        await using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                newOrder.Add(new OrderHistoryDB()
                                {
                                    OrderID = (int)reader[0],
                                    Date = (DateTime)reader[1],
                                    Comment = (string)reader[2],
                                    Item = (string)reader[3],
                                    Quantity = (int)reader[4],
                                    Price = Convert.ToSingle(reader[5])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SocketException)
                {
                    _logger.LogError("Could not connect to Database");
                    throw;
                }
                _logger.LogError(ex.Message);
            }

            return newOrder;
        }

        public async Task<IEnumerable<OrderHistoryDB>> SelectOrderHistory(string email)
        {
            _logger.LogInformation("Begin SelectOrderHistory");
            var orderHistory = new List<OrderHistoryDB>();
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
                        while (await reader.ReadAsync())
                        {
                            orderHistory.Add(new OrderHistoryDB()
                            {
                                OrderID = (int)reader[0],
                                Date = (DateTime)reader[1],
                                Comment = (string)reader[2],
                                Item = (string)reader[3],
                                Quantity = (int)reader[4],
                                Price = Convert.ToSingle(reader[5])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is SocketException) _logger.LogError("Could not connect to Database");
                _logger.LogError(ex.Message);
            }

            return orderHistory;
        }
    }
}
