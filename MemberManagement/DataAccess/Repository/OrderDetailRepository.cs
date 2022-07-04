using MemberManagement.DataAccess.ObjectDAO;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail order) => OrderDetailDAO.Instance.Addnew(order);
        public void DeleteOrderDetail(int orderId) => OrderDetailDAO.Instance.RemoveOrder(orderId);

        public OrderDetail GetOrderDetailById(int orderId) => OrderDetailDAO.Instance.GetOrderDetailById(orderId);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();

        public void UpdateOrderDetail(OrderDetail order) => OrderDetailDAO.Instance.UpdateOrderDetail(order);
    }
}
