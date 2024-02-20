using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Week2HomeWork3.DataAccess.Abstracts;
using Week2HomeWork3.Entities.Abstracts;

namespace Week2HomeWork3.DataAccess.Concretes.Repositories;
public class GenericRepository<T>:IEntityDal<T> where T : class,IEntity,new()
{
    List<T> list = new List<T>();
    public void Add(T entity)
    {
        list.Add(entity);
    }

    public void Update(T entity, Func<T,bool>filter)
    {
        var updateEntity = list.SingleOrDefault(filter);
        updateEntity = entity;

    }

    public void Delete(T entity)
    {
        list.Remove(entity);
    }

    public T GetById(Func<T, bool> filter)
    {
        return list.SingleOrDefault(filter);
    }

    public List<T> GetAll(Predicate<T> filter = null)
    {
        if(filter == null)
        {
            return list;
        }

        return list.FindAll(filter).ToList();
    }
}
