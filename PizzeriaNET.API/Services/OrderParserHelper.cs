﻿using PizzeriaNET.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaNET.API.Services
{
    public class OrderParserHelper : IOrderParserHelper
    {
        public IEnumerable<OrderHistory> ParseOrderHistory(IEnumerable<OrderHistoryDB> orderHistoryDb)
        {
            var orderHistory = new List<OrderHistory>();
            foreach (var entry in orderHistoryDb)
            {
                if (entry.OrderID == 0 || string.IsNullOrWhiteSpace(entry.Item)) throw new ArgumentException();
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
            if (orderEntryFirst.OrderID == 0 || string.IsNullOrWhiteSpace(orderEntryFirst.Item))
                throw new ArgumentException();
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
