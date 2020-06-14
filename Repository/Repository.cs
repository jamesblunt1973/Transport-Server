using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport_Server.Data;

namespace Transport_Server.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        protected readonly DataContext DbContext;

        public DbSet<TEntity> Table { get; }

        public Repository(DataContext dataContext)
        {
            DbContext = dataContext;
            Table = DbContext.Set<TEntity>(); 
        }

        #region AsyncMethods

        /// <summary>
        /// Get All Entities With Same Type TEntity
        /// </summary>
        /// <returns></returns>
        public async Task<List<TEntity>> Get()
        {
            return await Table.ToListAsync();
        }

        /// <summary>
        /// Get Specifiyed Entity By ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetById(int Id)
        {
            return await Table.FindAsync(Id);
        }

        /// <summary>
        /// Return The Added Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Add(TEntity entity)
        {
            Table.Add(entity);
            await DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update The Given Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Updated Entity</returns>
        public async Task Put(TEntity entity)
        {
            Table.Update(entity);
            await DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Delete The TEntity By Given ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task Delete(int Id)
        {
            Table.Remove(Table.Find(Id));
            await DbContext.SaveChangesAsync();
        }

        #endregion

    }
}
