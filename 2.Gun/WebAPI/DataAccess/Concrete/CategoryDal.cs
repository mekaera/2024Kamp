using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;

namespace WebAPI.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        Category category1 = new Category();
        category1.Id = 1;
        category1.Name = "category1";
        category1.Description = "desc1";
        category1.CategoryType = "type1";

        Category category2 = new Category();
        category2.Id = 2;
        category2.Name = "category2";
        category2.Description = "desc2";
        category2.CategoryType = "type2";

        _categories = new List<Category> { category1,category2};
            
    }
    public void Add(Category item)
    {
        _categories.Add(item);
    }

    public void Delete(Category item)
    {
        _categories.Remove(item);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.Find(x => x.Id == id);
    }

    public void Update(Category item)
    {
        Category? categoryToUpdate = _categories.Find(x => x.Id == item.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Description = item.Description;
            categoryToUpdate.Name = item.Name;
            categoryToUpdate.CategoryType = item.CategoryType;
        }
    }
}
