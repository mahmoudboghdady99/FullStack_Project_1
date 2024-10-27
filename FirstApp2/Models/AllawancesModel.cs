using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class AllawancesModel
    {
        public AllawancesModel()
        {
            EmployeeAllawances = new HashSet<EmployeeAllawanceModel>();

        }
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeAllawanceModel> EmployeeAllawances { get; set; }
    }
}
