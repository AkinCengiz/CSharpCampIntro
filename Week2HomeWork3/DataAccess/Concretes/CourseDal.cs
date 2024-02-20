using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.DataAccess.Abstracts;
using Week2HomeWork3.DataAccess.Concretes.Repositories;
using Week2HomeWork3.Entities.Concretes;

namespace Week2HomeWork3.DataAccess.Concretes;
public class CourseDal : GenericRepository<Course>, ICourseDal
{
}
