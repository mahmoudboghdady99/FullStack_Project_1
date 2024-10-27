using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class EmployeeAllawanceModel
    {
        public EmployeeAllawanceModel()
        {
            TbEmployee = new EmployeeModel();
            Tballawances = new AllawancesModel();
        }
        [Key]
        public int EmployeeAllawancesId { get; set; }
        public int EmployeeId { get; set; }
        public string AllawancesId { get; set; }

        public EmployeeModel TbEmployee { get; set; }
        public AllawancesModel Tballawances { get; set; }
       

    }
}
