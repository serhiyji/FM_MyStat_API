﻿using FluentValidation;
using FM_MyStat_API.Core.DTOs.SubjectsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Validation.Subject
{
    public class CreateSubjectValidation : AbstractValidator<CreateSubjectDTO>
    {
        public CreateSubjectValidation()
        {
            RuleFor(r => r.Name).NotEmpty().MaximumLength(64).MinimumLength(2);
        }
    }
}
