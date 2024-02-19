using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete.InMemory;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor> {
            new Instructor { InstructorId=1, FirstName = "Engin", LastName="Demiroğ"}
        };
    }
    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(Instructor entity)
    {
        Instructor instructorToDelete = _instructors.SingleOrDefault(i=>i.InstructorId ==entity.InstructorId);
        _instructors.Remove(instructorToDelete);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor entity)
    {
        Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.InstructorId == entity.InstructorId);
        instructorToUpdate.FirstName = entity.FirstName;
        instructorToUpdate.LastName = entity.LastName;
    }
}
