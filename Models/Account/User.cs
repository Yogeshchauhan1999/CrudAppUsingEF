using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models.Account
{
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool IsRemember { get; set; }

    }
}
