using WebAPI.Business.Abstract;
using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DataAccess.Concretes;

namespace WebAPI.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        var categoryToDelete = GetById(id);
        _categoryDal.Delete(categoryToDelete);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
