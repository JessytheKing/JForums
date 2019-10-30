using System.ComponentModel.DataAnnotations;

namespace JForums.Models.Account
{
    public class ExternalLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
