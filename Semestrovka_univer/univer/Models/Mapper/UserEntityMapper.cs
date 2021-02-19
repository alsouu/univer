using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using univer.Models.DTO;
using univer.Models.Entities;

namespace univer.Models.Mapper
{
    public static class UserEntityMapper
    {
        public static ProfileResponse MapUserToProfileResponse(UserEntity userEntity)
        {
            return new ProfileResponse()
            {
                Id = userEntity.Id,
                Username = userEntity.Username,
                Email = userEntity.Email,
                CreatedAt = userEntity.CreatedAt,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                Patronymic = userEntity.Patronymic,
                BirthDate = userEntity.BirthDate.ToString(),
            };
        }

        public static UserEntity MapFromRegisterDto(Registerdto dto)
        {
            return new UserEntity()
            {
                CreatedAt = DateTime.Now,
                Username = dto.Username,
                Email = dto.Email,
                Password = dto.Password
            };
        }
    }
}
