using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class EmployeeData
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "**Required field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "**Required field")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "**Required field")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Enter the Valid User Email!")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "**Required field")]
        public String Dptname { get; set; }

        [Required(ErrorMessage = "**Required field")]
        public int Salary { get; set; }
        
    }
}
