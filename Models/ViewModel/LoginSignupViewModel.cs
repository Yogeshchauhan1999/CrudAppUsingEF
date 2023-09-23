using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models.ViewModel
{
    public class LoginSignupViewModel
    {
        [Key]
        public int uid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemember { get; set; }

    }
}
