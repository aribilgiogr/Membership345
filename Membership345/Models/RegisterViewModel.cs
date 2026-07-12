namespace Membership345.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string? DisplayName { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string Country { get; set; } = null!;
        public string? City { get; set; }
        public string? District { get; set; }
    }
}
