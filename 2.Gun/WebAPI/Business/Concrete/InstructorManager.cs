using WebAPI.Business.Abstract;
using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;

namespace WebAPI.Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructor;

    public InstructorManager(IInstructorDal instructor)
    {
        _instructor = instructor;
    }

    public void Add(Instructor category)
    {
        _instructor.Add(category);
    }

    public void Delete(int id)
    {
        var instructorToDelete = _instructor.GetById(id);
        if (instructorToDelete != null)
        {
            _instructor.Delete(instructorToDelete);
        }
  
    }

    public List<Instructor> GetAll()
    {
        return _instructor.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _instructor.GetById(id);
    }

    public void Update(Instructor instructor)
    {
       _instructor.Update(instructor);
    }
}
