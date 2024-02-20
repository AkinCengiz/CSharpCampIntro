using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.Entities.Abstracts;

namespace Week2HomeWork3.Entities.Concretes;
public class Instructor : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
