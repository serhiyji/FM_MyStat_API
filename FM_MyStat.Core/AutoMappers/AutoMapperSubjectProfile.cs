using AutoMapper;
using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using FM_MyStat_API.Core.DTOs.SubjectsDTO;
using FM_MyStat_API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.AutoMappers
{
    public class AutoMapperSubjectProfile : Profile
    {
        public AutoMapperSubjectProfile()
        {
            CreateMap<CreateSubjectDTO, Subject>().ReverseMap();
            CreateMap<DeleteSubjectDTO, Subject>().ReverseMap();
            CreateMap<EditSubjectDTO, Subject>().ReverseMap();
            CreateMap<SubjectDTO, Subject>().ReverseMap();
            CreateMap<SubjectUpdateDTO, Subject>().ReverseMap();
        }
    }
}
