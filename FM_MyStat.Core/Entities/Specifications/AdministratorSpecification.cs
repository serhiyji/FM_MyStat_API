using Ardalis.Specification;
using FluentValidation;
using FM_MyStat_API.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FM_MyStat_API.Core.Entities.Specifications
{
    public class AdministratorSpecification : AbstractValidator<Administrator>
    {
        public class GetByAppUserId : Specification<Administrator>
        {
            public GetByAppUserId(string Id)
            {
                Query.Where(a => a.AppUserId == Id);
            }
        }
    }
}
