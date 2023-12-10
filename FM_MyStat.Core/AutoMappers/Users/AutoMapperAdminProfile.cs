using AutoMapper;
using FM_MyStat_API.Core.DTOs.UsersDTO.Admin;
using FM_MyStat_API.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.AutoMappers.Users
{
    internal class AutoMapperAdminProfile : Profile
    {
        public AutoMapperAdminProfile()
        {
            CreateMap<AdminDTO, AppUser>().ReverseMap();
            CreateMap<AdminDTO, Administrator>().ReverseMap();
            CreateMap<EditAdminDTO, AppUser>().ReverseMap();
            CreateMap<EditAdminDTO, AppUser>().ReverseMap();
            CreateMap<CreateAdminDTO, AppUser>().ForMember(dst => dst.UserName, act => act.MapFrom(src => src.Email));

            CreateMap<CreateAdminDTO, Administrator>().ReverseMap();
        }
    }
}
