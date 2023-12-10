using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.DTOs.UsersDTO.User
{
    public class DeleteUserDTO
    {
        public string Id { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
