﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.LessonsDTO.LessonMark
{
    public class DeleteLessonMarkDTO
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
    }
}