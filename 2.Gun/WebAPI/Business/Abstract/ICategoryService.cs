using WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Business.Abstract;

public interface ICategoryService
{
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);
    List<Category> GetAll();
    Category GetById(int id);
}
