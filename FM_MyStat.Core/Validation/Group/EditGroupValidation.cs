using FluentValidation;
using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Validation.Group
{
    public class EditGroupValidation : AbstractValidator<EditGroupDTO>
    {
        public EditGroupValidation()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2).MaximumLength(50);  
        }
    }
}
