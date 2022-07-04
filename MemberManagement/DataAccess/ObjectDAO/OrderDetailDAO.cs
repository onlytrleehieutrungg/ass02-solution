using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.ObjectDAO
{
    public class OrderDetailDAO
    {
        private OrderDetailDAO()
        {

        }

        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var orderdetails = new List<OrderDetail>();
            try
            {
                using var context = new FStoreDBContext();
                orderdetails = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderdetails;
        }

        public OrderDetail GetOrderDetailById(int orderId)
        {
            OrderDetail ord = null;
            try
            {
                using var context = new FStoreDBContext();
                ord = context.OrderDetails.SingleOrDefault(o => o.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ord;
        }

        public void Addnew(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail ord = GetOrderDetailById(orderdetail.OrderId);
                if (ord == null)
                {
                    using var context = new FStoreDBContext();
                    context.OrderDetails.Add(orderdetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail ord = GetOrderDetailById(orderdetail.OrderId);

                if (ord != null)
                {
                    using var context = new FStoreDBContext();
                    context.OrderDetails.Update(orderdetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveOrder(int orderId)
        {
            try
            {
                OrderDetail ord = GetOrderDetailById(orderId);
                if (ord != null)
                {
                    using var context = new FStoreDBContext();
                    context.OrderDetails.Remove(ord);
                }
                else
                {
                    throw new Exception("order dose not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
