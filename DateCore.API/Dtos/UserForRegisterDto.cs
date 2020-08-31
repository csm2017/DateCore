using System.ComponentModel.DataAnnotations;

namespace DateCore.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 18 characters")]
        public string Password { get; set; }
    }
}