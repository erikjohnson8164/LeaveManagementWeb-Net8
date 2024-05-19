using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId = "eac43a6e-f7bb-4448-baaf-1add431ccbbf", // Administrator Role
                     UserId = "gd8b15cf-52af-4a97-ab4b-824616a0a45f" // Admin User
                 },
                 new IdentityUserRole<string>
                 {
                     RoleId = "eac43a7e-f7cb-4148-baaf-1acb431ccbbf", // User Role
                     UserId = "d1b30e9a-d2fc-4083-8bff-eeb2d4d80d4c" // Normal User
                 }

             );
        }
    }
}