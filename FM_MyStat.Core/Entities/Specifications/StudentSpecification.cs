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
    public class StudentSpecification : AbstractValidator<Student>
    {
        public class GetById : Specification<Student>
        {
            public GetById(int Id)
            {
                Query.Where(x => x.Id == Id);
            }
        }
        public class GetByAppUserId : Specification<Student>
        {
            public GetByAppUserId(string Id)
            {
                Query.Where(a => a.AppUserId == Id);
            }
        }
        public class GetByGroupId : Specification<Student>
        {
            public GetByGroupId(int Id)
            {
                Query.Where(a => a.GroupId == Id);
            }
        }
        public class GetByManyGroupId : Specification<Student>
        {
            public GetByManyGroupId(IEnumerable<int> Ids)
            {
                Query.Where(a => Ids.Contains((int)a.GroupId));
            }
        }
    }
}
