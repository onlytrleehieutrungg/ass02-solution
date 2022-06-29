using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.ObjectDAO
{
    public class CategoryDAO
    {
        private CategoryDAO()
        {

        }

        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();

        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Category> GetCategoryList()
        {
            var categories = new List<Category>();
            try
            {
                using var context = new FStoreDBContext();
                categories = context.Categories.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }

        public Category GetCategoryById(int CategoryId)
        {
            Category category = null;

            try
            {
                using var context = new FStoreDBContext();
                category = context.Categories.SingleOrDefault(c => c.CategoryId == CategoryId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return category;
        }
        public void AddNew(Category category)
        {
            try
            {
                Category cate = GetCategoryById(category.CategoryId);
                if (cate == null)
                {
                    using var context = new FStoreDBContext();
                    context.Categories.Add(cate);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The category does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void UpdateCategory(Category category)
        {
            try
            {
                Category cate = GetCategoryById(category.CategoryId);
                if (cate != null)
                {
                    using var context = new FStoreDBContext();
                    context.Categories.Update(cate);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The category does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void RemoveCategory(int CategoryId)
        {
            try
            {
                Category category = GetCategoryById(CategoryId);
                if (category != null)
                {
                    using var context = new FStoreDBContext();
                    context.Categories.Remove(category);

                }
                else
                {
                    throw new Exception("Category dose not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
