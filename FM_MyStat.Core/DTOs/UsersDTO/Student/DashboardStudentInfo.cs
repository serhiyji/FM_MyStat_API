using FM_MyStat_API.Core.DTOs.UsersDTO.Student;

namespace FM_MyStat_API.Web.Models.ViewModels.Student
{
    public class DashboardStudentInfo
    {
        public StudentDTO StudentInfo { get; set; }
        public string Group { get; set; }
        public int RatingGroup { get; set; }
        public int HomeworksAll { get; set; } // всі
        public int HomeworksChecked { get; set; } // перевірені
        public int HomeworksCurrent { get; set; } // поточні
        public int HomeworksOnInspection { get; set; } //  на перевірці
        public int HomeworksOverdue { get; set; } //  протерміновано    
        public List<StudentDTO> RatingList { get; set; }
    }
}
