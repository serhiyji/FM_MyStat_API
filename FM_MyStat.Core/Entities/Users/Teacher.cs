﻿using FM_MyStat_API.Core.Entities.Lessons;
using FM_MyStat_API.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Entities.Users
{
    public class Teacher : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<TeacherSubject> TeachersSubjects { get; set; }
        public IEnumerable<Lesson> Lessons { get; set; }
    }
}
