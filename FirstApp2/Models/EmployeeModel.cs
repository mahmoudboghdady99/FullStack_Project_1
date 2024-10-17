using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="please enter your name")]
        [StringLength(100, ErrorMessage ="must be than less 100")]
        public string Name { get; set; } = "";
        [Required]
        [StringLength(100, ErrorMessage = "must be than less 100")]
        public string Department { get; set; } = "";
        [Required]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "please enter your Title")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "must be than less 100")]
        public string Email { get; set; } = "";
        public string Description { get; set; } = "";
        [Required]
        [StringLength(100, ErrorMessage = "must be than less 4000")]
        public string ImageName { get; set; } = "";
    }
}
