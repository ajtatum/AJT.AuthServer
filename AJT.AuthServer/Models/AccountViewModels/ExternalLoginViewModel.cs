using System.ComponentModel.DataAnnotations;

namespace AJT.AuthServer.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
