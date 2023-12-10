using Ardalis.Specification;
using FM_MyStat_API.Core.Entities.Homeworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FM_MyStat_API.Core.Entities.Specifications
{
    public class HomeworkSpecification
    {
        public class GetByTitle : Specification<Homework>
        {
            public GetByTitle(string title)
            {
                Query.Where(x => x.Title == title);
            }
        }
        public class GetByGroupId : Specification<Homework>
        {
            public GetByGroupId(int Id)
            {
                Query.Where(x => x.GroupId == Id);
            }
        }
    }
}
