using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Identity;

namespace Security.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                        Email = "gtfofo97@gmail.com",
                        NormalizedEmail = "gtfofo97@gmail.com",
                        Nombre = "Gustavo Pineda",
                        UserName = "itsgustavo97",
                        NormalizedUserName = "itsgustavo97",
                        PasswordHash = hasher.HashPassword(null, "ABCDabcd1234$"),
                        EmailConfirmed = true,
                    },
                    new ApplicationUser
                    {
                        Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                        Email = "gustavofofo_97@outlook.com",
                        NormalizedEmail = "gustavofofo_97@outlook.com",
                        Nombre = "Adolfo Montes",
                        UserName = "itsadolfo97",
                        NormalizedUserName = "itsadolfo97",
                        PasswordHash = hasher.HashPassword(null, "ABCDabcd1234$"),
                        EmailConfirmed = true,
                    }

                );


        }
    }
}
