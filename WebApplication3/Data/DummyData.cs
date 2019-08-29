using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext  context,
                             UserManager<ApplicationUser> userManager,
                             RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();



            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Doctor";
            string desc2 = "This is the Doctor role";


            string role3 = "Assistant";
            string desc3 = "This is the assistant role";


            string role4 = "Patient";
            string desc4 = "This is the patient role";

            string role5 = "InsuranceCompany";
            string desc5 = "This is the insurance company role";

            string password = "123@Abc";

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

            if (await roleManager.FindByNameAsync(role5) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role5, desc5, DateTime.Now));
            }





            if (await userManager.FindByNameAsync("mhmdbk@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "mhmdbk@gmail.com",
                    Email = "mhmdbk@gmail.com",
                    FirstName = "mhamad",
                    LastName = "Barek",
                     PhoneNumber = "+96176939233",
                };
                 var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }
        }
    }
}

    

