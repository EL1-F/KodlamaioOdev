using Kodlamaio.Business.Abstract;
using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concrete;

public class InstructorManager : IInstructorService
{
    IInstructorDal _insructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _insructorDal = instructorDal;
    }
    public void Add(Instructor instructor)
    {
        _insructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _insructorDal.Delete(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _insructorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
        _insructorDal.Update(instructor);
    }
}
