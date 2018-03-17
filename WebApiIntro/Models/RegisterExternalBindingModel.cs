using System.ComponentModel.DataAnnotations;

namespace WebApiIntro.Models
{
    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}