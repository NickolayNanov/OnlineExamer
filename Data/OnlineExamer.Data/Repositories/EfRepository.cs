namespace Examer.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Examer.Data.Common.Repositories;

    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class

    {
        public EfRepository(OnlineExamerDbContext context)
        {
            this.Context = context;
            this.Data = this.Context.Set<TEntity>();
        }

        protected DbSet<TEntity> Data { get; set; }

        protected OnlineExamerDbContext Context { get; set; }

        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.Data;
        }

        public IQueryable<TEntity> AllAsNoTracking()
        {
            return this.Data.AsNoTracking();
        }

        public void Delete(TEntity entity)
        {
            this.Data.Remove(entity);
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);

            if(entry.State == EntityState.Detached)
            {
                this.Context.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
    }
}
