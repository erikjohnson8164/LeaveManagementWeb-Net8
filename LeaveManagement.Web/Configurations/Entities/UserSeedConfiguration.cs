using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "gd8b15cf-52af-4a97-ab4b-824616a0a45f",
                    Email = "admin@localhost.org",
                    NormalizedEmail = "ADMIN@LOCALHOST.ORG",
                    UserName = "admin@localhost.org",
                    NormalizedUserName = "ADMIN@LOCALHOST.ORG",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    LockoutEnabled = false
                },
                new Employee
                {
                    Id = "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c",
                    Email = "user@localhost.net",
                    NormalizedEmail = "USER@LOCALHOST.NET",
                    UserName = "user@localhost.net",
                    NormalizedUserName = "USER@LOCALHOST.NET",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    LockoutEnabled = false
                }
            );
        }
    }
}