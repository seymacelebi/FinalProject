using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    public interface IEntityRepository<T> where T:class, IEntity, new()
    { 
        //productmanager da getall gibi linq sorguları yazabilmemizi sağlar. 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //tek bir detaya gitmek için kullanılır.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //bu koda ihtiyacımız kalmadı.
        //List<T> GetAllByCategory(int categoryId);
    }
}
