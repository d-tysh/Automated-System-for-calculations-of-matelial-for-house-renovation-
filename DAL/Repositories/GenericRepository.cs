using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        DbContext context;
        IDbSet<T> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public void AddOrUpdate(T obj)
        {
            try
            {
                dbSet.AddOrUpdate(obj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(T obj)
        {
            try
            {
                dbSet.Remove(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return dbSet.Where(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Get(int id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            { 
                return dbSet;
            }
            catch (Exception ex)
            {
                throw ex;    
            }
        }

        public void Save()
        {
            try
            { 
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
