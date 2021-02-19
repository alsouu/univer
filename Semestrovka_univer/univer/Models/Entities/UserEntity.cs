using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace univer.Models.Entities
{
    public class UserEntity : DbEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        public string FirstName
        {
            get;
            set;
        } = "";

        public string LastName { get; set; } = "";
        public string Patronymic { get; set; } = "";
        public DateTime BirthDate { get; set; }
    }
    
}
