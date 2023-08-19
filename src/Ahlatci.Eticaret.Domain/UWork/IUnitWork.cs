using Ahlatci.Eticaret.Application.Repositories;
using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.UWork
{
    public interface IUnitWork : IDisposable
    {
        public IRepository<T> GetRepository<T>() where T : BaseEntity;
        public Task<bool> CommitAsync();
    }
}

