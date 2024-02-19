using Kodlamaio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstract;

public interface ICourseDal:IEntityRepository<Course>
{
    List<Course> GetByCategoryId(int categoryId);
    List<Course> GetByInsructorId(int insructorId);
}
