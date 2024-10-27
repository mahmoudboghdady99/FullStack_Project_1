using FirstApp2.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FirstApp2.Areas.CustomValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp2.Models
{
    public class EmployeeModel
    {
        public EmployeeModel() 
        {
            TbDepartment = new DepartmentsModel();
            EmployeeVacations = new HashSet<EmployeeVacation>();
            TbPerson = new PersonModel();
            EmployeeAllawances = new HashSet<EmployeeAllawanceModel>();
        }
        [Key]
        [ValidateNever]
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter your name")]
        [StringLength(100, ErrorMessage ="must be than less 100")]

        public string Name { get; set; } = "";
        [Required(ErrorMessage = "please enter your Department")]
        [StringLength(100, ErrorMessage = "must be than less 100")]
        public string Department { get; set; } = "";
        [Required(ErrorMessage = "please enter your Title")]
        [StringLength(80, ErrorMessage = "must be than less 80")]

        public string Title { get; set; } = "";
        [Required]
        [EmailAddress(ErrorMessage ="enter valid email")]
        [StringLength(100, ErrorMessage = "must be  less than 100")]
        [Remote(action: "VerifyEmail", controller: "Employees", ErrorMessage="email found")]
        [ValidateEmail("gmail", ErrorMessage ="you must use gmail only")]
        public string Email { get; set; } = null;
        public string Description { get; set; } = "";
       
        public string? ImageName { get; set; } = "";

        public int DepartmentId { get; set; }

        
        public int PersonId { get; set; }
        public PersonModel TbPerson { get; set; }
       
        // الربط مع القسم
        public DepartmentsModel TbDepartment { get; set; }
        public ICollection<EmployeeVacation> EmployeeVacations { get; set; }

        public ICollection<EmployeeAllawanceModel> EmployeeAllawances { get; set; }
    }
}
