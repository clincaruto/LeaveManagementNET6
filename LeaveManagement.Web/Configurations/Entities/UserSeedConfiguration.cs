//using LeaveManagement.Data.Data;
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
                    Id = "408aa945-3d84-4421-8342-7269ec64d949",
                    Email = "clindropadmin@gmail.com",
                    NormalizedEmail = "CLINDROPADMIN@GMAIL.COM",
                    NormalizedUserName = "CLINDROPADMIN@GMAIL.COM",
                    UserName = "clindropadmin@gmail.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },

                 new Employee
                 {
                     Id = "3f4631bd-f907-4409-b415-ba356312e659",
                     Email = "clindropuser@gmail.com",
                     NormalizedEmail = "CLINDROPUSER@GMAIL.COM",
                     NormalizedUserName = "CLINDROPUSER@GMAIL.COM",
                     UserName = "clindropuser@gmail.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
             );
        }
    }
}