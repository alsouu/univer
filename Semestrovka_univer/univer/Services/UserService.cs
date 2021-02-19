using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using univer.Models.DTO;
using univer.Models.Entities;
using univer.Models.Repository;

namespace univer.Services
{
    public class UserService
    {
        private UserRepo _userRepo;

        public UserService(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task EditProfile(UserEntity userEntity, EditProfileDto data)
        {
            await _userRepo.Update(userEntity, new UserEntity()
            {
                FirstName = data.FirstName ?? userEntity.FirstName,
                LastName = data.LastName ?? userEntity.LastName,
                Patronymic = data.Patronymic ?? userEntity.Patronymic,
                BirthDate = data.BirthDate != "" ? Convert.ToDateTime(data.BirthDate) : userEntity.BirthDate
            });
        }
    }

}
