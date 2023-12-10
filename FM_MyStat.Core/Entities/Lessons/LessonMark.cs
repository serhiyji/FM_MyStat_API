using FM_MyStat_API.Core.Entities.Users;
using FM_MyStat_API.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Entities.Lessons
{
    public class LessonMark : IEntity
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public int StudentId {  get; set; }
        public Student Student { get; set; }
    }
}
