using MemberManagement.DataAccess.ObjectDAO;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.Addnew(order);

        public void DeleteOrder(int orderId) => OrderDAO.Instance.RemoveOrder(orderId);

        public Order GetOrder(int orderId) => OrderDAO.Instance.GetOrderById(orderId);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList(); 

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
