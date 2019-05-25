using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TestePraticoWevo.Models;

namespace TestePraticoWevo.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : Cliente
    {
         IEnumerable<TEntity> GetAll();
         TEntity GetById(int id);
         void Insert(ref TEntity entity);
         bool Update(TEntity entity);
         bool Delete(Int32 id);
    }
}