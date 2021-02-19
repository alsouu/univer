using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using univer.Models.DTO;
using univer.Models.Entities;

namespace univer.Models.Repository.Interfaces
{
    public interface DaoBase <T>
    {
        public T FindById(int id);
        public Task<Pageable<T>> Read(PageableArgs args);
        public Task<T> Create(T data);
        public Task<T> Update(T sourceObject, T updatedFields);
        public Task Delete(T sourceObject);
        protected T MapToEntity(NpgsqlDataReader reader);
    }
}
