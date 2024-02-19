using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);

    List<Course> GetByCategoryId(int categoryId);
    List<Course> GetByInsructorId(int insructorId);
}
