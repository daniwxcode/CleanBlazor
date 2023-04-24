using Domain.Contracts;

namespace Application.Contracts.Repos
{
    public interface IRepositoryAsync<T, in TId> where T : class, IEntity<TId>
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(TId id);

        Task<List<T>> GetAllAsync();
        Task<List<T>> GetPagedResponseAsync(int pageNumber, int pageSize);

        Task<T> AddAsync(T entity);
        Task<List<T>> AddRangeAsync(List<T> entity);

        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> entity);

        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(List<T> entity);
    }
}