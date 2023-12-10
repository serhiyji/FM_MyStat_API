using AutoMapper;
using FM_MyStat_API.Core.DTOs.UsersDTO.Student;
using FM_MyStat_API.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM_MyStat_API.Core.Entities.Homeworks;
using FM_MyStat_API.Core.DTOs.HomeworksDTO.Homework;
namespace FM_MyStat_API.Core.AutoMappers
{
    public class AutoMapperHomework : Profile
    {
        public AutoMapperHomework()
        {
            CreateMap<Homework, HomeworkDTO>().ReverseMap();
            CreateMap<CreateHomeworkDTO, Homework>().ReverseMap();
            CreateMap<Homework, CreateHomeworkDTO>().ReverseMap();
            CreateMap<DeleteHomeworkDTO, Homework>().ReverseMap();
            CreateMap<EditHomeworkDTO, Homework>().ReverseMap();
        }
    }
}
