using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete.InMemory;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course> {
            new Course {  CourseId=1,InstructorId=1,CategoryId=1, Name="Yazılım Geliştirici Yetiştirme Kampı-C#", Price=0},
            new Course {  CourseId=2,InstructorId=2,CategoryId=1, Name="Yazılım Geliştirici Yetiştirme Kampı-Python", Price=0},
            new Course {  CourseId=3,InstructorId=1,CategoryId=1, Name="Yazılım Geliştirici Yetiştirme Kampı-Java", Price=0}
        };
    }
    public void Add(Course entity)
    {
        _courses.Add(entity);
    }

    public void Delete(Course entity)
    {
        Course courseToDelete = _courses.SingleOrDefault(c=>c.CourseId == entity.CourseId);
        _courses.Remove(courseToDelete);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public List<Course> GetByCategoryId(int categoryId)
    {
        return _courses.Where(c => c.CategoryId == categoryId).ToList();
    }

    public List<Course> GetByInsructorId(int insructorId)
    {
        return _courses.Where(c => c.InstructorId == insructorId).ToList();
    }

    public void Update(Course entity)
    {
        Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == entity.CourseId);
        courseToUpdate.CategoryId = entity.CategoryId;
        courseToUpdate.InstructorId = entity.InstructorId;
        courseToUpdate.Price = entity.Price;
    }
}
