using NUnit.Framework;
using PizzeriaNET.API.Models;
using PizzeriaNET.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaNET.API.Tests
{
    //[TestFixture]
    public class OrderParserHelperTests
    {
        private readonly IOrderParserHelper _orderParserHelper;

        public OrderParserHelperTests()
        {
            _orderParserHelper = new OrderParserHelper();
        }

        [Test]
        public void ParseNewOrder_GivenGoodParams_ReturnsParsedOrder()
        {
            //Arrange
            var newOrderFromDb = new List<OrderHistoryDB>()
            {
                new OrderHistoryDB()
                {
                    OrderID = 1,
                    Comment = "comment",
                    Item = "Pizza",
                    Quantity = 1,
                    Price = 20,
                    Date = new DateTime()
                },
                new OrderHistoryDB()
                {
                    OrderID = 1,
                    Comment = "comment",
                    Item = "OtherPizza",
                    Quantity = 2,
                    Price = 25,
                    Date = new DateTime()
                },
                new OrderHistoryDB()
                {
                    OrderID = 1,
                    Comment = "comment",
                    Item = "AnotherPizza",
                    Quantity = 3,
                    Price = 15,
                    Date = new DateTime()
                }
            };
            var expected = new OrderHistory()
            {
                ID = 1,
                Date = new DateTime(),
                Comment = "comment",
                OrderItems = new List<OrderHistoryItem>()
                {
                    new OrderHistoryItem()
                    {
                        Name = "Pizza",
                        Quantity = 1,
                        Price = 20
                    },
                    new OrderHistoryItem()
                    {
                        Name = "OtherPizza",
                        Quantity = 2,
                        Price = 25
                    },
                    new OrderHistoryItem()
                    {
                        Name = "AnotherPizza",
                        Quantity = 3,
                        Price = 15
                    },
                }
            };

            //Act
            var actual = _orderParserHelper.ParseNewOrder(newOrderFromDb);

            //Assert
            //Probably there is more elegant solution
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Comment, actual.Comment);
            Assert.AreEqual(expected.Date, actual.Date);
            Assert.AreEqual(expected.OrderItems.Count, actual.OrderItems.Count);
        }

        [Test]
        public void ParseNewOrder_GivenBadParams_ThrowsArgumentException()
        {
            //Arrange
            var newOrderFromDb = new List<OrderHistoryDB>()
            {
                new OrderHistoryDB(),
                new OrderHistoryDB(),
                new OrderHistoryDB()
            };

            //Act
            try
            {
                _ = _orderParserHelper.ParseNewOrder(newOrderFromDb);
            }
            catch (ArgumentException e)
            {
                Assert.Pass();
            }

            //Assert
            Assert.Fail();
        }

        [Test]
        public void ParseOrderHistory_GivenGoodParams_ReturnsParsedHistory()
        {
            //Arrage
            var orderHistoryFromDb = new List<OrderHistoryDB>()
            {
                new OrderHistoryDB()
                {
                    OrderID = 1,
                    Comment = "comment",
                    Item = "Pizza",
                    Quantity = 1,
                    Price = 20,
                    Date = new DateTime()
                },
                new OrderHistoryDB()
                {
                    OrderID = 1,
                    Comment = "comment",
                    Item = "OtherPizza",
                    Quantity = 2,
                    Price = 25,
                    Date = new DateTime()
                },
                new OrderHistoryDB()
                {
                    OrderID = 2,
                    Comment = "comment",
                    Item = "AnotherPizza",
                    Quantity = 3,
                    Price = 15,
                    Date = new DateTime()
                },
                new OrderHistoryDB()
                {
                    OrderID = 2,
                    Comment = "comment",
                    Item = "AnotherPizza",
                    Quantity = 1,
                    Price = 10,
                    Date = new DateTime()
                }
            };
            var expected = new List<OrderHistory>()
            {
                new OrderHistory()
                {
                    ID = 1,
                    Date = new DateTime(),
                    Comment = "comment",
                    OrderItems = new List<OrderHistoryItem>()
                    {
                        new OrderHistoryItem()
                        {
                            Name = "Pizza",
                            Quantity = 1,
                            Price = 20
                        },
                        new OrderHistoryItem()
                        {
                            Name = "OtherPizza",
                            Quantity = 2,
                            Price = 25
                        }
                    }
                },
                new OrderHistory()
                {
                    ID = 2,
                    Date = new DateTime(),
                    Comment = "comment",
                    OrderItems = new List<OrderHistoryItem>()
                    {
                        new OrderHistoryItem()
                        {
                            Name = "AnotherPizza",
                            Quantity = 3,
                            Price = 15
                        },
                        new OrderHistoryItem()
                        {
                            Name = "OtherPizza",
                            Quantity = 1,
                            Price = 10
                        }
                    }
                }
            };

            //Act
            var actual = _orderParserHelper.ParseOrderHistory(orderHistoryFromDb);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count());
            Assert.AreEqual(expected.First().OrderItems.Count, actual.First().OrderItems.Count);
        }

        [Test]
        public void ParseOrderHistory_GivenBadParams_ThrowsArgumentException()
        {
            //Arrange
            var orderHistoryFromDb = new List<OrderHistoryDB>()
            {
                new OrderHistoryDB(),
                new OrderHistoryDB(),
                new OrderHistoryDB(),
                new OrderHistoryDB()
            };

            //Act
            try
            {
                _ = _orderParserHelper.ParseOrderHistory(orderHistoryFromDb);
            }
            catch (ArgumentException e)
            {
                Assert.Pass();
            }

            //Assert
            Assert.Fail();
        }
    }
}
