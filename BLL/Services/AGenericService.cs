using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class AGenericService<T> : IGenericService<T>
        where T : class, new()
    {
        IGenericRepository<T> repository;

        public AGenericService(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }


        public T Add(T obj)
        {
            try
            {
                repository.AddOrUpdate(obj);
                repository.Save();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Delete(int id)
        {
            T elem = repository.Get(id);
            repository.Delete(elem);
            repository.Save();
            return elem;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return repository.FindBy(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Get(int id)
        {
            T elem = repository.Get(id);
            return elem;
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public void Save()
        {
            repository.Save();
        }

        public T Update(T obj)
        {
            repository.AddOrUpdate(obj);
            repository.Save();
            return obj;
        }
    }
}
