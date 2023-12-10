using FM_MyStat_API.Core.DTOs.UsersDTO.User;
using FM_MyStat_API.Core.Entities;
using FM_MyStat_API.Core.Entities.Lessons;
using FM_MyStat_API.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.UsersDTO.Teacher
{
    public class TeacherDTO : UserDTO
    {
        public string? AppUserId { get; set; }
    }
}
