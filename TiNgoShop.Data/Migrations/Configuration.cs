namespace TiNgoShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<TiNgoShop.Data.TiNgoShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TiNgoShop.Data.TiNgoShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TiNgoShopDbContext()));
            var roleManager= new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TiNgoShopDbContext()));
            var user = new ApplicationUser() {
                UserName = "tingo",
                Email = "dinhlamsan@yahoo.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "TiNgoShop"
            };
            manager.Create(user, "123@456");
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminuser = manager.FindByEmail("dinhlamsan@yahoo.com");
            manager.AddToRoles(adminuser.Id, new string[] { "Admin", "User" });
        }
    }
}
