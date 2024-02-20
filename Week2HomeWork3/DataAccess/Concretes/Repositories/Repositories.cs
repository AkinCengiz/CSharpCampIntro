using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.Entities.Concretes;

namespace Week2HomeWork3.DataAccess.Concretes.Repositories;
public static class Repositories
{
    public static List<Course> courses = new List<Course>();
    public static List<Category> categories = new List<Category>();
    public static List<Instructor> instructors = new List<Instructor>();
}
