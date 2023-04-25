using System.ComponentModel.DataAnnotations;

namespace Application.Framework.Requests.Identity
{
    public class ChangePasswordRequest
    {
        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string NewPassword { get; set; } = string.Empty;

        [Required]
        public string ConfirmNewPassword { get; set; } = string.Empty;

    }
}