using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Services
{
    public class OrderParserHelper : IOrderParserHelper
    {
        public IEnumerable<OrderHistory> ParseOrderHistory(IEnumerable<OrderHistoryDB> orderHistoryDb)
        {
            var orderHistory = new List<OrderHistory>();
            foreach (var entry in orderHistoryDb)
            {
                var index = orderHistory.FindIndex(item => item.ID == entry.OrderID);
                if (index < 0)
                {
                    orderHistory.Add(new OrderHistory()
                    {
                        ID = entry.OrderID,
                        Date = entry.Date,
                        Comment = entry.Comment,
                        OrderItems = new List<OrderHistoryItem>
                        {
                            new OrderHistoryItem()
                            {
                                Name = entry.Item,
                                Quantity = entry.Quantity,
                                Price = entry.Price
                            }
                        }
                    });
                }
                else orderHistory[index].OrderItems.Add(new OrderHistoryItem()
                {
                    Name = entry.Item,
                    Quantity = entry.Quantity,
                    Price = entry.Price
                });
            }

            return orderHistory;
        }

        public OrderHistory ParseNewOrder(IEnumerable<OrderHistoryDB> newOrderFromDb)
        {
            var orderEntryFirst = newOrderFromDb.First();
            var order = new OrderHistory()
            {
                ID = orderEntryFirst.OrderID,
                Date = orderEntryFirst.Date,
                Comment = orderEntryFirst.Comment,
                OrderItems = new List<OrderHistoryItem>()
            };
            foreach (var entry in newOrderFromDb)
            {
                order.OrderItems.Add(new OrderHistoryItem()
                {
                    Name = entry.Item,
                    Quantity = entry.Quantity,
                    Price = entry.Price
                });
            }

            return order;
        }
    }
}
