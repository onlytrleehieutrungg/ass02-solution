using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetOrders();
        Order GetOrder(int orderId);
        void AddOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrder(Order order);

    }
}
