using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using FM_MyStat_API.Core.DTOs.LessonsDTO.Lessons;
using FM_MyStat_API.Core.DTOs.UsersDTO.Teacher;
using FM_MyStat_API.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Interfaces
{
    public interface ILessonService
    {
        Task<List<LessonDTO>> GetAll();
        Task<LessonDTO?> Get(int id);
        Task<ServiceResponse> GetByName(LessonDTO model);
        Task<LessonDTO> GetByName(string Name);
        Task Create(CreateLessonsDTO model);
        Task Update(EditLessonsDTO model);
        Task Delete(int id);
        Task<ServiceResponse<List<LessonDTO>, object>> GetLessonDTOByTeacher(string id);
    }
}
