using System.Collections.Generic;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Services
{
    public interface IOrderParserHelper
    {
        public IEnumerable<OrderHistory> ParseOrderHistory(IEnumerable<OrderHistoryDB> orderHistoryDb);
        public OrderHistory ParseNewOrder(IEnumerable<OrderHistoryDB> newOrderFromDb);
    }
}