using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using univer.Models.Entities;

namespace univer.Models.Repository
{
    public interface IUserRepo
    {
        public Task<UserEntity> FindByEmail(string email);
    }
}