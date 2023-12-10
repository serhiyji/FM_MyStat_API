using FM_MyStat_API.Core.DTOs.UsersDTO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.UsersDTO.Student
{
    public class StudentDTO : UserDTO
    {
        public int Rating { get; set; }
        public int? GroupId { get; set; }
        public string Group { get; set; }
    }
}
