using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StockManagerAC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagerAC.Models
{
    public class Registro
    {
        public static void Initialize(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("User.UserName123@mail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "User.UserName123@mail.com",
                    Email = "User.UserName123@mail.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "User.UserPassword123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

        }

    }
}

