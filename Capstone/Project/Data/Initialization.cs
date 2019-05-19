using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public class Initialization
    {
        public static async Task Initialize(ApplicationDbContext context,
                               UserManager<ApplicationUser> userManager,
                               RoleManager<ApplicationRole> roleManager)
        {

            context.Database.EnsureCreated();

            string role1 = "Disabled";
            string desc1 = "This role represents a disabled user account.";

            string role2 = "Administrator";
            string desc2 = "This is the Administrator Role";

            string role3 = "Instructor";
            string desc3 = "This is the Instructor Role";

            string role4 = "DataEntry";
            string desc4 = "This is the Data Entry Role";


            /*
             * Currently Unused Roles
            string role5 = "Doctor";
            string desc5 = "This is the BRIT Doctor Role";

            string role6 = "Nurse";
            string desc6 = "This is the BRIT Nurse Role";
            *
            */

            // Generic Hardcoded test password
            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role3, desc3, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role4) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role4, desc4, DateTime.Now));
            }

            /*
             * Currently Unused role initialization
            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
            *
            */

            if (await userManager.FindByNameAsync("admin@testing.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@testing.com",
                    Email = "admin@testing.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    FacilityId = 11
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }

            }
        }
    }
}
