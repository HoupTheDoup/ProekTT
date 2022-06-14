namespace WebLibrary.Web.Extensions
{
    using Microsoft.AspNetCore.Identity;
    using WebLibrary.Data.Entities;

    public static class WebApplicationExtensions
    {
        public static async Task SeedRolesAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (roleManager.Roles.Any())
            {
                return;
            }

            var adminRole = CreateRole("admin");

            await roleManager.CreateAsync(adminRole);
        }

        public static async Task SeedUsersAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<UserEntity>>();

            if (userManager.Users.Any())
            {
                return;
            }

            var admin = CreateUser("admin@admin.com");

            await userManager.CreateAsync(admin, "admin123");
            await userManager.AddToRoleAsync(admin, "admin");
        }

        private static IdentityRole CreateRole(string name)
            => new IdentityRole
            {
                Name = name,
                NormalizedName = name.ToUpper(),
            };

        private static UserEntity CreateUser(string email, params string[] roles)
            => new UserEntity
            {
                UserName = email,
                Email = email,
            };
    }
}