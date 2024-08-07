﻿using Ardalis.Specification;
using FM_MyStat_API.Core.Entities.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FM_MyStat_API.Core.Entities.Specifications
{
    public class LessonsMarkSpecification
    {
        public class GetById : Specification<LessonMark>
        {
            public GetById(int Id)
            {
                Query.Where(x => x.Id == Id);
            }
        }

        public class GetByStudentId : Specification<LessonMark>
        {
            public GetByStudentId(int Id)
            {
                Query.Where(x => x.StudentId == Id);
            }
        }

        public class GetByLessonId : Specification<LessonMark>
        {
            public GetByLessonId(int lessonId, int studentId)
            {
                Query.Where(x => x.LessonId == lessonId && x.StudentId == studentId);
            }
        }
    }
}
