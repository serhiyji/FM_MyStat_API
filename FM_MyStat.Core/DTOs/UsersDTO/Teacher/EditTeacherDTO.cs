using FM_MyStat_API.Core.Entities.Lessons;
using FM_MyStat_API.Core.Entities.Users;
using FM_MyStat_API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.UsersDTO.Teacher
{
    public class EditTeacherDTO
    {
        public int Id { get; set; }
        public string? AppUserId { get; set; }
    }
}
