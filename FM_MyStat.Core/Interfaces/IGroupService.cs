using FM_MyStat_API.Core.DTOs.GrouopsDTO;
using FM_MyStat_API.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Interfaces
{
    public interface IGroupService
    {
        Task<List<GroupDTO>> GetAll();
        Task<GroupDTO?> Get(int id);
        Task<ServiceResponse> GetByName(string name);
        Task Create(CreateGroupDTO model);
        Task Update(EditGroupDTO model);
        Task Delete(int id);
        Task<ServiceResponse<EditGroupDTO, object>> GetEditGroupDTO(int id);
        Task<ServiceResponse<List<GroupDTO>, object>> GetGroupDTOByTeacher(string id);
    }
}
