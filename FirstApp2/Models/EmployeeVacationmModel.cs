using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class EmployeeVacation
    {
        public EmployeeVacation()
        {
            TbEmployee = new EmployeeModel();
        }
        public int EmployeeVacationId { get; set; }
        public DateTime startDate { get; set; } 
        public DateTime endDate { get; set; } 
        public string Description   { get; set; }
        public int vacationType { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel TbEmployee { get; set; }
    }
}
