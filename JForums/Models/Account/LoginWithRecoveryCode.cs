using System.ComponentModel.DataAnnotations;

namespace JForums.Models.Account
{
    public class LoginWithRecoveryCode
    {

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
