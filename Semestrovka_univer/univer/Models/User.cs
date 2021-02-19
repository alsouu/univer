using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace univer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NumberGroup { get; set; }
        public string Login { get; set; }
        public string PasswordKey { get; set; }
        public string BirthDate { get; set; }
        public string Favteacher { get; set; }
    }
}
