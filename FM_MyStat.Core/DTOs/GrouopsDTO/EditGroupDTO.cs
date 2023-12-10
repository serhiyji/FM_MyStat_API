using FM_MyStat_API.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM_MyStat_API.Core.Entities.Homeworks;

namespace FM_MyStat_API.Core.DTOs.GrouopsDTO
{
    public class EditGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TeacherId { get; set; }
    }
}
