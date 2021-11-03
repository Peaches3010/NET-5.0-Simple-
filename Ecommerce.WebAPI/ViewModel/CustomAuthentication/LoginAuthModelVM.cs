using System.ComponentModel.DataAnnotations;

namespace Ecommerce.WebAPI.ViewModel.CustomAuthentication
{
    public class LoginAuthModelVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}