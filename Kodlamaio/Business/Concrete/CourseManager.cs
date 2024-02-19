using Kodlamaio.Business.Abstract;
using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concrete;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll(); 
    }

    public List<Course> GetByCategoryId(int categoryId)
    {
        return _courseDal.GetByCategoryId(categoryId);
    }

    public List<Course> GetByInsructorId(int insructorId)
    {
        return _courseDal.GetByInsructorId(insructorId);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
