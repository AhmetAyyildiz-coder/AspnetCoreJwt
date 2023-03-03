using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Repositories
{
    internal interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int id);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> exp = null);

       Task AddAsync(T entity);


        void Delete(T entity);

        T Update(T entity); // _context.Entry(entity).state = EntityState.Modified;
        
    }
}
