//using LeaveManagement.Data.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {     //clindropadmin@gmail.com ADMIN
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "408aa945-3d84-4421-8342-7269ec64d949" //clindrop@gmail.com ADMIN
                },           
                 new IdentityUserRole<string>
                 {    //clindropuser@gmail.com USER
                     RoleId = "cac43a7e-f7cb-4148-baaf-1acb431aebbf",
                     UserId = "3f4631bd-f907-4409-b415-ba356312e659"  //clindrop2@gmail.com USER
                 }
             );
        }
    }
}