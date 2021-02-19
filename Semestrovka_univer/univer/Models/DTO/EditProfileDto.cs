using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace univer.Models.DTO
{
    public class EditProfileDto
    {
        [StringLength(32, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(32, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(32, MinimumLength = 2)]
        public string Patronymic { get; set; }

        public string BirthDate { get; set; }
    }
}
