using System.Diagnostics;
using System.Xml.Linq;
using Week2HomeWork3.DataAccess.Concretes;
using Week2HomeWork3.Entities.Concretes;

namespace Week2HomeWork3;

internal class Program
{
    static void Main(string[] args)
    {
        CourseDal courseDal = new CourseDal();
        courseDal.Add(new Course(){Id = 1, Description = "sdsdsdsds", Price = 100, CategoryId = 1, CompletionRate = 0, ImageUrl = "wewew", InstructorId = 1, Name = "C#"});
        

        Console.WriteLine((courseDal.GetById(x => x.Id == 1)).Name);
        courseDal.GetById(x => x.Id == 1);
        Course course2 = new Course() { Id = 2, Description = "Javaaaaa", Price = 200, CategoryId = 1, CompletionRate = 0, ImageUrl = "jjjjwewew", InstructorId = 1, Name = "JAVA" };
        courseDal.Add(course2);
        foreach (var course in courseDal.GetAll())
        {
            Console.WriteLine(course.Name + " " + course.ImageUrl);
        }
        
        var updatedCourse = courseDal.GetById(x => x.Id == 1);
        updatedCourse.ImageUrl = "Güncellendi...";
        courseDal.Update(updatedCourse,y => y.Id == updatedCourse.Id);
        Console.WriteLine("Hello, World!");

        foreach (var course in courseDal.GetAll())
        {
            Console.WriteLine(course.Name);
        }
    }
}
