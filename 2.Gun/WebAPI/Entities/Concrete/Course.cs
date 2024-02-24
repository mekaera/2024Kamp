using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Entities;

public class Course : BaseEntity
{   
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public double Price { get; set; }   
}
