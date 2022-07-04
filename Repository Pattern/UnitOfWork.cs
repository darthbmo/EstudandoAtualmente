using EstudosGerais.Exemplos.Repository_Pattern.Interfaces;
using EstudosGerais.Model.Entities;

namespace EstudosGerais.Exemplos.Repository_Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        
        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        Task<bool> IUnitOfWork.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
