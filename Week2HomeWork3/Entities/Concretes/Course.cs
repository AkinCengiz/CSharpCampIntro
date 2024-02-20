using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.Entities.Abstracts;

namespace Week2HomeWork3.Entities.Concretes;
public class Course : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal CompletionRate { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
}
