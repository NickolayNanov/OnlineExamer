namespace OnlineExamer.Data.Common.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        IQueryable<TEntity> All(Expression<Func<TEntity, bool>> expression = null);

        IQueryable<TEntity> AllAsNoTracking(Expression<Func<TEntity, bool>> expression = null);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression = null);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void HardDelete(TEntity entity);

        void SoftDelete(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
