using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterView.Domain.ModelConfigurations;

public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
{
    public void Configure(EntityTypeBuilder<IdentityUser> builder)
    {
        builder.HasData(new IdentityUser
        {
            Id = "dd7a5b70-da03-11ed-afa1-0242ac120002",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "InterView@email.com",
            NormalizedEmail = "INTERVIEW@EMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
            SecurityStamp = string.Empty
        });
    }
}
