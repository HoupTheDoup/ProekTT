using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Data.Entities;
using WebLibrary.Data.Repositories;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Services;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<WebLibraryDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services
    .AddDefaultIdentity<UserEntity>(options =>
    {
        options.User.RequireUniqueEmail = true;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<WebLibraryDbContext>();

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<IGenreService, GenreService>();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddAutoMapper(typeof(WebLibrary.Web.MapperProfile));
builder.Services.AddAutoMapper(typeof(WebLibrary.Data.MapperProfile));


var app = builder.Build();

await app.SeedRolesAsync();
await app.SeedUsersAsync();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
