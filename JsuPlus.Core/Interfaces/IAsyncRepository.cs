using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JsuPlus.Core.SharedKernel;

namespace JsuPlus.Core.Interfaces
{
    public interface IAsyncRepository
    {
        Task<T> GetById<T>(Guid id) where T : BaseEntity;
        ////List<T> List<T>(ISpecification<T> spec = null) where T : BaseEntity;
        Task<T> Add<T>(T entity) where T : BaseEntity;
        //void Update<T>(T entity) where T : BaseEntity;
        //void Delete<T>(T entity) where T : BaseEntity;

    }
}
