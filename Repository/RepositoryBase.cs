using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dommel;
using TestePraticoWevo.Models;
using TestePraticoWevo.Repository.Configurations;

namespace TestePraticoWevo.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Cliente
    {
        public virtual bool Delete(Int32 id)
        {
            using(var db = new SqlConnection(DbConnection.GetConn())){
                var entity = GetById(id);
                if(entity == null)
                    throw new Exception("Registro não encontrado");
                
                return db.Delete(entity);
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            using(var db = new SqlConnection(DbConnection.GetConn())){
                return db.GetAll<TEntity>();
            }
        }

        public virtual TEntity GetById(int id)
        {
            using(var db = new SqlConnection(DbConnection.GetConn())){
                return db.Get<TEntity>(id);
            }
        }


         public virtual void Insert(ref TEntity entity)
        {
            using (var db = new SqlConnection(DbConnection.GetConn()))
            {
                var id = db.Insert(entity);
 
                entity = GetById((int)id);
            }
        }

        public virtual bool Update(TEntity entity)
        {
            using (var db = new SqlConnection(DbConnection.GetConn()))
            {
                return db.Update(entity);
            }
        }
    }
}