using System.ComponentModel.DataAnnotations;

namespace InvoiceManager_ASP.NET_MVC.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}