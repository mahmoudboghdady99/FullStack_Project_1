namespace FirstApp2.Models
{
    public class DepartmentsModel
    {
        public DepartmentsModel() 
        {
            Employees = new HashSet<EmployeeModel>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }



        // قائمة الموظفين في القسم
        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
