﻿using System.ComponentModel.DataAnnotations;

namespace Application.Framework.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}