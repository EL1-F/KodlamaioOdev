using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete.InMemory;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category> {
            new Category { CategoryId=1, CategoryName = "Programlama"}
        };
    }
    public void Add(Category entity)
    {
        _categories.Add(entity);
    }

    public void Delete(Category entity)
    {
        Category categoryToDelete = _categories.SingleOrDefault(c=>c.CategoryId == entity.CategoryId);
        _categories.Remove(categoryToDelete);
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        return _categories.SingleOrDefault(filter.Compile());
    }

    public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
    {
        if (filter == null)
        {
            return _categories;
        }
        else
        {
            return _categories.Where(filter.Compile()).ToList();
        }
    }

    public void Update(Category entity)
    {
        Category categoryToUpdate = _categories.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
        categoryToUpdate.CategoryName= entity.CategoryName;
    }
}
