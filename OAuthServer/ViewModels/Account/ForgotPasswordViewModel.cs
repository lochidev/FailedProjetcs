﻿using System.ComponentModel.DataAnnotations;

namespace OAuthServer.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
