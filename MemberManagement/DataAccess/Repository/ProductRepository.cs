using MemberManagement.DataAccess.ObjectDAO;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product) => ProductDAO.Instance.AddNew(product);

        public void DeleteProduct(int productId) => ProductDAO.Instance.RemoveProduct(productId);

        public Product GetProduct(int productId) => ProductDAO.Instance.GetProductByID(productId);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
