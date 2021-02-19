using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using univer.Models.Entities;

namespace univer.Models.DTO
{
    public class UserResponse
    {
        public ProfileResponse Profile { get; set; }
        public UserEntity User { get; set; }
    }
}
