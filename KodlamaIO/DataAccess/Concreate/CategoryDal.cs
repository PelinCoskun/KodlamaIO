using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concreate
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {

            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" }
            };
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Kategori Adı: {category.Name}");
            }

            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
            }
        }

        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

    }
}
