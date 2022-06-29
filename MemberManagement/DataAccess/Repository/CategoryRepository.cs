using MemberManagement.DataAccess.ObjectDAO;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category category) => CategoryDAO.Instance.AddNew(category);

        public void DeleteCategory(int productId) => CategoryDAO.Instance.RemoveCategory(productId);

        public IEnumerable<Category> GetCategories() => CategoryDAO.Instance.GetCategoryList();

        public Category GetCategory(int categoryId) => CategoryDAO.Instance.GetCategoryById(categoryId);

        public void UpdateCategory(Category category) => CategoryDAO.Instance.UpdateCategory(category);
    }
}
