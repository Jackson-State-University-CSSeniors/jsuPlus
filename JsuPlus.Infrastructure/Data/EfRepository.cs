using JsuPlus.Core.Entities;
using JsuPlus.Core.Interfaces;
using JsuPlus.Core.SharedKernel;
using System.Collections.Generic;
using System.Linq;
using MySql.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JsuPlus.Infrastructure.Data
{
    public class EfRepository : IAsyncRepository
    {
        private readonly JSUPlusDbContext _dbContext;

        public EfRepository(JSUPlusDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetById<T>(Guid id) where T : BaseEntity
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public async Task<T> Add<T>(T entity) where T : BaseEntity
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
