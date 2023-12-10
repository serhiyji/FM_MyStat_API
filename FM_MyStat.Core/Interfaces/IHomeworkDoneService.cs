using FM_MyStat_API.Core.DTOs.HomeworksDTO;
using FM_MyStat_API.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Interfaces
{
    public interface IHomeworkDoneService
    {
        Task<List<HomeworkDoneDTO>> GetAll();
        Task<List<HomeworkDoneDTO>> GetAll(int homeworkId);
        Task<HomeworkDoneDTO?> Get(int id);
        Task<ServiceResponse> GetByName(HomeworkDoneDTO model);
        Task<HomeworkDoneDTO> GetByName(string NameDescription);
        Task Create(HomeworkDoneDTO model);
        Task Update(HomeworkDoneDTO model);
        Task Delete(int id);
        Task<(byte[] fileContents, string contentType, string fileName)> DownloadHomeworkFileAsync(int homeworkId);
    }
}
