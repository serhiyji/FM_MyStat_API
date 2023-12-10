using AutoMapper;
using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using FM_MyStat_API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.AutoMappers
{
    public class AutoMapperGroupProfile : Profile
    {
        public AutoMapperGroupProfile()
        {
            CreateMap<CreateGroupDTO, Group>().ReverseMap();
            CreateMap<DeleteGroupDTO, Group>().ReverseMap();
            CreateMap<EditGroupDTO, Group>().ReverseMap();
            CreateMap<GroupDTO, Group>().ReverseMap();
        }
    }
}
