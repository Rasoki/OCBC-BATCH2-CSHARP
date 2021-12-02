using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}