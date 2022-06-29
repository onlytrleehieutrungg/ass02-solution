using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.ObjectDAO
{
    public class ProductDAO
    {
        private ProductDAO()
        {

        }

        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }


        public IEnumerable<Product> GetProductList()
        {
            var products = new List<Product>();
            try
            {
                using var context = new FStoreDBContext();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product GetProductByID(int productId)
        {
            Product product = null;
            try
            {
                using var context = new FStoreDBContext();
                product = context.Products.SingleOrDefault(p => p.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void AddNew(Product product)
        {
            try
            {
                Product pro = GetProductByID(product.ProductId);
                if (pro == null)
                {
                    using var context = new FStoreDBContext();
                    context.Products.Add(pro);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The pro does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Product pro = GetProductByID(product.ProductId);
                if (pro != null)
                {
                    using var context = new FStoreDBContext();
                    context.Products.Update(pro);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The pro does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void RemoveProduct(int productId)
        {
            try
            {
                Product pro = GetProductByID(productId);
                if (pro != null)
                {
                    using var context = new FStoreDBContext();
                    context.Products.Remove(pro);
                }
                else
                {
                    throw new Exception("Member dose not already exists.");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
