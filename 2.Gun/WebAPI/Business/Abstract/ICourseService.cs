using WebAPI.Entities;

namespace WebAPI.Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);
    List<Course> GetAll();
    Course GetById(int id);
}
