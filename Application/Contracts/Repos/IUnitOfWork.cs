using Domain.Contracts;

namespace Application.Contracts.Repos
{
    public interface IUnitOfWork<TId> : IDisposable
    {
        IRepositoryAsync<T, TId> Repository<T>() where T : AuditableEntity<TId>;
        Task<int> Commit(CancellationToken cancellationToken);
        Task<int> CommitAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);
        Task<int> RemoveCache(CancellationToken cancellationToken);
        Task Rollback();
    }
}