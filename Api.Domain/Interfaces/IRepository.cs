using Api.Domain.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync (T item);
        Task<T> UpdateAsync (T item);
        Task<bool> DeleteAsync (Guid Id);
        Task<T> SelectAsync (Guid Id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(Guid id);

    }
}