using System.ComponentModel.DataAnnotations;

namespace MyFirstMVCWebApp.Dto
{
    public class UserDto
    {
        [Key]
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
