using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro.Business;
public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //business rules
        
        return _courseDal.GetAll();
    }

    
}
