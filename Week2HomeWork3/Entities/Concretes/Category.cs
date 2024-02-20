using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.Entities.Abstracts;

namespace Week2HomeWork3.Entities.Concretes;
public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
