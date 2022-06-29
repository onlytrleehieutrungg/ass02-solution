using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        Product GetProduct(int productId);
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);


    }
}
