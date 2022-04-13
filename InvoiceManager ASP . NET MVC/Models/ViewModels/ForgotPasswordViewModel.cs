using System.ComponentModel.DataAnnotations;

namespace InvoiceManager_ASP.NET_MVC.Models
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
