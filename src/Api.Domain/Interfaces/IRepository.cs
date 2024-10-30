﻿using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid Id);
        Task<T> SelectAsync(Guid Id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(Guid Id);

    }
}
