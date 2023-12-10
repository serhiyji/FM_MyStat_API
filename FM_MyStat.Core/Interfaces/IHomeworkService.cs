using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using FM_MyStat_API.Core.DTOs.HomeworksDTO.Homework;
using FM_MyStat_API.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Interfaces
{
    public interface IHomeworkService
    {
        Task<List<HomeworkDTO>> GetAll();
        Task<List<HomeworkDTO>> GetAllByUserId(string studentId);
        Task<HomeworkDTO?> Get(int id);
        Task<ServiceResponse> GetByName(HomeworkDTO model);
        Task<HomeworkDTO> GetByName(string NameHomework);
        Task Create(CreateHomeworkDTO model);
        Task Update(CreateHomeworkDTO model);
        Task Delete(int id);
        Task<ServiceResponse<CreateHomeworkDTO, object>> GetCreateHomeworkDTO(int id);
        Task<(byte[] fileContents, string contentType, string fileName)> DownloadHomeworkFileAsync(int homeworkId);
    }
}
