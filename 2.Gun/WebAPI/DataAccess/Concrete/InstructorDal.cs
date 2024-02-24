using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;
using System.Linq;

namespace WebAPI.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;

    public InstructorDal()
    {

        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.Name = "Instructor1";
        instructor1.Description = "Desc1";

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.Name = "Instructor2";
        instructor2.Description = "Desc2";

       _instructors = new List<Instructor> { instructor1,instructor2 };

    }
    public void Add(Instructor item)
    {
        _instructors.Add(item);
    }

    public void Delete(Instructor item)
    {
        _instructors.Remove(item);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor GetById(int id)
    {
        return _instructors.Find(x => x.Id == id);
    }

    public void Update(Instructor item)
    {
        Instructor? instructorToUpdate = _instructors.Find(x => x.Id == item.Id);
        if(instructorToUpdate != null)
        {
            instructorToUpdate.Description = item.Description;
            instructorToUpdate.Name = item.Name;
        }
    }

}
