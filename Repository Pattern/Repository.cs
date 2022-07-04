
using EstudosGerais.Context;
using System.Linq.Expressions;

namespace EstudosGerais.Exemplos.Repository_Pattern.Interfaces
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RepositoryContext _context;
        
        public Repository(RepositoryContext context)
        {
            _context = context;
        }

        void IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<T>> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }

    }
}
