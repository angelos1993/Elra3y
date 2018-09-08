using System.Collections.Generic;
using System.Linq;
using Elra3y.BLL.Infrastructure;
using Elra3y.DAL.Model;
using Elra3y.DAL.VMs;

namespace Elra3y.BLL
{
    public class CategoryManager : BaseManager
    {
        public void AddNewCategory(Category category)
        {
            UnitOfWork.CategoryRepository.Add(category);
        }

        public Category GetCategoryById(int categoryId)
        {
            return UnitOfWork.CategoryRepository.GetById(categoryId);
        }

        public List<Category> GetAllCategories()
        {
            return UnitOfWork.CategoryRepository.GetAll().ToList();
        }

        public List<CategoryVm> GetAllCategoriesVmsOrderedByName()
        {
            return UnitOfWork.CategoryRepository.GetAll().OrderBy(category => category.Name)
                .Select(category => new CategoryVm
                {
                    Id = category.Id,
                    Name = category.Name
                }).ToList();
        }

        public void UpdateCategory(Category category)
        {
            UnitOfWork.CategoryRepository.Update(category);
        }
    }
}