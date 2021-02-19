using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace univer.Models.DTO
{
    public class CreateReviewDto
    {

        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
    }
}
