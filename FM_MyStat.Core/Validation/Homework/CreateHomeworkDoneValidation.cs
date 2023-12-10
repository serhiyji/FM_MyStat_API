﻿using FluentValidation;
using FM_MyStat_API.Core.DTOs.HomeworksDTO;
using FM_MyStat_API.Core.DTOs.HomeworksDTO.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Validation.Homework
{
    public class CreateHomeworkDoneValidation : AbstractValidator<HomeworkDoneDTO>
    {
        public CreateHomeworkDoneValidation()
        {
            RuleFor(r => r.File).NotEmpty();
        }
    }
}
