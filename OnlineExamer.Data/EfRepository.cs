using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineExamer.Data.Common.EntityInfrastructure;
using OnlineExamer.Data.Common.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineExamer.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IDeletable

    {
        public EfRepository(
            ApplicationDbContext context)
        {
            this.Context = context;
            this.Data = this.Context.Set<TEntity>();
        }

        protected DbSet<TEntity> Data { get; set; }

        protected ApplicationDbContext Context { get; set; }

        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public IQueryable<TEntity> All(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = this.Data.Where(expression);
            return entities;
        }

        public IQueryable<TEntity> AllAsNoTracking(Expression<Func<TEntity, bool>> expression = null)
        {
            var entities = this.Data.Where(expression).AsNoTracking();
            return entities;
        }

        public void SoftDelete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.UtcNow;

            this.Update(entity);
        }

        public void HardDelete(TEntity entity)
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

            if (entry.State == EntityState.Detached)
            {
                this.Context.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
    }
}