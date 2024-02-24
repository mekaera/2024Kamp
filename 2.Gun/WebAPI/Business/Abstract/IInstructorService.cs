using WebAPI.Entities;

namespace WebAPI.Business.Abstract;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);
    List<Instructor> GetAll();
    Instructor GetById(int id);
}
