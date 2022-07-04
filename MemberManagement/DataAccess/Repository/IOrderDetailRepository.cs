using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailById(int orderId);
        void AddOrderDetail(OrderDetail order);
        void DeleteOrderDetail(int orderId);
        void UpdateOrderDetail(OrderDetail order);
    }
}
