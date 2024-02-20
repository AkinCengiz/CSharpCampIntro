using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;
public class CourseDal :ICourseDal
{
    private List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8 vs...";
        course1.Price = 0;

        Course course2 = new()
        {
            Id = 2,
            Name = "Java",
            Description = "Java ile Nesne Yönelimli Programlama",
            Price = 100
        };

        Course course3 = new()
        {
            Id = 3,
            Name = "Python",
            Description = "Python ile Veri Bilimi",
            Price = 0
        };
        courses = new() { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        
        //burada db işlemleri yapılır.
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}