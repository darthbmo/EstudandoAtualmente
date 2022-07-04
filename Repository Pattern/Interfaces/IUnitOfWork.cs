using EstudosGerais.Model.Entities;

namespace EstudosGerais.Exemplos.Repository_Pattern.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Repositórios
        
        Task<bool> SaveChangesAsync();
    }
}
