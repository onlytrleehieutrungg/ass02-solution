using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        Category GetCategory(int categoryId);
        void AddCategory(Category category);
        void DeleteCategory(int productId);
        void UpdateCategory(Category category);
    }
}
