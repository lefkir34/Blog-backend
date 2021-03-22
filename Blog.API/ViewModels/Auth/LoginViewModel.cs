
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace Blog.API.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}