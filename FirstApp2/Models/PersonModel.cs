using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class PersonModel
    {
     
        public PersonModel()
        {
            TbEmployee = new EmployeeModel();
        }
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public EmployeeModel TbEmployee { get; set; }
    }
}
