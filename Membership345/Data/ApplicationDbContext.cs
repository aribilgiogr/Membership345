using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Membership345.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationUserRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<UserLink> UserLinks { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string Country { get; set; } = null!;
        public string? City { get; set; }
        public string? District { get; set; }
        public virtual ICollection<UserLink> Links { get; set; } = [];
    }

    public class ApplicationUserRole : IdentityRole
    {
        public string? Description { get; set; }
    }

    public class UserLink
    {
        public int Id { get; set; }
        public string Link { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
