using System.ComponentModel.DataAnnotations;

namespace JForums.Models.Account
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
