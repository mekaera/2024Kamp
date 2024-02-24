using WebAPI.DataAccess.Abstracts;
using WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;

    public CourseDal()
    {
        Course course = new Course();
        course.Id = 1;
        course.Name = "Course1";
        course.Description = "Desc1";
        course.Price = 0;
        course.InstructorId = 1;
        course.CategoryId = 1;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Course2";
        course2.Description = "Desc2";
        course2.Price = 0;
        course2.InstructorId = 2;
        course2.CategoryId = 2;

        _courses = new List<Course> { course, course2 }; 

    }
    public void Add(Course item)
    {
        _courses.Add(item);
    }

    public void Delete(Course item)
    {
        _courses.Remove(item);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
       return _courses.Find(x => x.Id == id);
    }

    public void Update(Course item)
    {
        Course? courseToUpdate = _courses.Find(x => x.Id == item.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.Description = item.Description;
            courseToUpdate.Name = item.Name;
            courseToUpdate.Price = item.Price;
            courseToUpdate.InstructorId = item.InstructorId;
            courseToUpdate.CategoryId = item.CategoryId;
        }
    }
}
