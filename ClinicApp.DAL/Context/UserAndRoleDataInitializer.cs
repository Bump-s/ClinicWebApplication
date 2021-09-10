using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context
{
    public static class UserAndRoleDataInitializer
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("johndoe@localhost").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "johndoe@localhost";
                user.Email = "johndoe@localhost";
                user.Id = "b783a270-d154-45a2-b1e2-d950da9661db";

                IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }


            if (userManager.FindByEmailAsync("alex@localhost").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "alex@localhost";
                user.Email = "alex@localhost";
                user.Id = "b783a270-d154-45a2-b1e2-d950da9662db";

                IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.Id = "b782a270-d154-45a2-b1e2-d950da9661db";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
            
            if (!roleManager.RoleExistsAsync("Doctor").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Doctor";
                role.Id = "b182a270-d154-45a2-b1e2-d950da9661db";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
            
            if (!roleManager.RoleExistsAsync("Patient").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Patient";
                role.Id = "b982a270-d154-45a2-b1e2-d950da9661db";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.Id = "b783a270-d154-85a2-b1e2-d950da9661db";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}

