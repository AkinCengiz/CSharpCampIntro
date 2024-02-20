using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.Entities.Abstracts;

namespace Week2HomeWork3.DataAccess.Abstracts;
public interface IEntityDal<T> where T : class, IEntity, new()
{
    void Add(T entity);
    void Update(T entity, Func<T, bool> filter);
    void Delete(T entity);
    T GetById(Func<T, bool> filter);
    List<T> GetAll(Predicate<T> filter = null);
}
