using FM_MyStat_API.Core.Entities.Lessons;
using FM_MyStat_API.Core.Entities.Users;
using FM_MyStat_API.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Entities
{
    public class Subject : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(128)]
        public string Name { get; set; }
        public IEnumerable<TeacherSubject> TeachersSubjects { get; set; }
        public IEnumerable<Lesson> Lessons { get; set; }
    }
}
