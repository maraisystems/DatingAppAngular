using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 100 characters.")]
        public string Password { get; set; }
    }
}