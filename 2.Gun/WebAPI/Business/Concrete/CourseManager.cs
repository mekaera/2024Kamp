using WebAPI.Business.Abstract;
using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;

namespace WebAPI.Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course category)
    {
        _courseDal.Add(category);
    }

    public void Delete(int id)
    {
        var categoryToDelete = GetById(id);
        _courseDal.Delete(categoryToDelete);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public void Update(Course category)
    {
        _courseDal.Update(category);
    }
}
