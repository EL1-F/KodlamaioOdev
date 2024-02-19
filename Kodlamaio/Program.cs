using Kodlamaio.Business.Concrete;
using Kodlamaio.DataAccess.Concrete.InMemory;
using Kodlamaio.Entities.Concrete;

namespace Kodlamaio;

internal class Program
{
    static void Main(string[] args)
    {
        //InsructorTest();
        //CategoryTest();
        //CourseTest();
    }

    private static void InsructorTest()
    {
        InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
        Instructor ınstructor = new Instructor { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };
        ınstructorManager.Add(ınstructor);
        foreach (var item in ınstructorManager.GetAll())
        {
            Console.WriteLine("- " + item.FirstName + " " + item.LastName);
        }
        Console.WriteLine("-----------------------------------");
        ınstructorManager.Delete(ınstructor);
        foreach (var item in ınstructorManager.GetAll())
        {
            Console.WriteLine("- " + item.FirstName + " " + item.LastName);
        }
        Console.WriteLine("-----------------------------------");
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        Category category = new Category { CategoryId = 2, CategoryName = "Grafik Tasarım" };
        categoryManager.Add(category);
        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.CategoryName);
        }
        Console.WriteLine("---------------");
        categoryManager.Delete(category);
        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.CategoryName);
        }
        Console.WriteLine("---------------");
    }

    private static void CourseTest()
    {
        CourseManager courseManager = new CourseManager(new CourseDal());
        Course course = new Course { CourseId = 4, InstructorId = 1, CategoryId = 2, Name = "Yazılım Geliştirici Yetiştirme Kampı-Javascript", Price = 0 };
        courseManager.Add(course);
        foreach (var item in courseManager.GetAll())
        {
            Console.WriteLine(item.Name+" --> "+item.Price);
        }
        Console.WriteLine("------------------------------");

        foreach (var item in courseManager.GetByInsructorId(1))
        {
            Console.WriteLine(item.Name + " --> " + item.InstructorId);
        }
        Console.WriteLine("------------------------------");

        foreach (var item in courseManager.GetByCategoryId(2))
        {
            Console.WriteLine(item.Name + " --> "  + item.CategoryId);
        }
        Console.WriteLine("------------------------------");

        courseManager.Delete(course);

        foreach (var item in courseManager.GetAll())
        {
            Console.WriteLine(item.Name + " --> " + item.Price);
        }
        Console.WriteLine("------------------------------");
    }
}
