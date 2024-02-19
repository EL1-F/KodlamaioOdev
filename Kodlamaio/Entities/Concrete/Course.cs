using Kodlamaio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Entities.Concrete;

public class Course:IEntity
{
    public int CourseId { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
