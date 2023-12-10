using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.UsersDTO.Student
{
    public class StudentMarkDTO : StudentDTO
    {
        public int Mark { get; set; }
        public int LessonMarkId { get; set; }
    }
}
