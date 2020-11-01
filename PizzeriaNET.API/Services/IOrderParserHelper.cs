using PizzeriaNET.API.Models;
using System.Collections.Generic;

namespace PizzeriaNET.API.Services
{
    public interface IOrderParserHelper
    {
        public IEnumerable<OrderHistory> ParseOrderHistory(IEnumerable<OrderHistoryDB> orderHistoryDb);
        public OrderHistory ParseNewOrder(IEnumerable<OrderHistoryDB> newOrderFromDb);
    }
}