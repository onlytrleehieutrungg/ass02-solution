using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.ObjectDAO
{
    public class OrderDAO
    {
        private OrderDAO()
        {

        }

        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();


        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new FStoreDBContext();
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            Order ord = null;
            try
            {
                using var context = new FStoreDBContext();
                ord = context.Orders.SingleOrDefault(o => o.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ord;
        }

        public void Addnew(Order order)
        {
            try
            {
                Order ord = GetOrderById(order.OrderId);
                if (ord == null)
                {
                    using var context = new FStoreDBContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order does not already exist");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                Order ord = GetOrderById(order.OrderId);

                if (ord != null)
                {
                    using var context = new FStoreDBContext();
                    context.Orders.Update(ord);
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
                Order ord = GetOrderById(orderId);
                if (ord != null)
                {
                    using var context = new FStoreDBContext();
                    context.Orders.Remove(ord);
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
