using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AJsCleaning.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var pwd = "AJsCleaning39671@!";
            var passwordHasher = new PasswordHasher<IdentityUser>();

            //Seeding Roles
            var adminRole = new IdentityRole("Administrator");
            adminRole.NormalizedName = adminRole.Name.ToUpper();

            var userRole = new IdentityRole("User");
            userRole.NormalizedName = userRole.Name.ToUpper();

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                adminRole,
                userRole,
            };

            builder.Entity<IdentityRole>().HasData(roles);

            var adminUser = new IdentityUser
            {
                UserName = "admin@ajscleaningsvc.com",
                Email = "admin@ajscleaningsvc.com",
                EmailConfirmed = true
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            List<IdentityUser> users = new List<IdentityUser>()
            {
                adminUser
            };

            builder.Entity<IdentityUser>().HasData(users);

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string> 
            { 
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Administrator").Id
            });
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
