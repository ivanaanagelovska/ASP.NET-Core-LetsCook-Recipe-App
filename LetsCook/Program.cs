using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using LetsCook.Data;
using LetsCook.Infrastructure;
using LetsCook.Services.Recipes;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder
    .Services
    .AddDbContext<LetsCookDbContext>(options => options.UseSqlServer(connectionString));

builder
    .Services
    .AddDatabaseDeveloperPageExceptionFilter();

builder
    .Services
    .AddDefaultIdentity<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<LetsCookDbContext>();

builder
    .Services
    .AddControllersWithViews();

builder
    .Services
    .AddTransient<ICategoryService, CategoryService>();

builder
    .Services
    .AddTransient<ICuisineService, CuisineService>();

builder
    .Services
    .AddTransient<IDifficultyService, DifficultyService>();

builder
    .Services
    .AddTransient<IRecipesService, RecipesService>();

var app = builder.Build();

app.DbInitializer();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app
    .UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAuthentication()
    .UseAuthorization()
    .UseEndpoints(endpoints =>
   {
       endpoints.MapDefaultControllerRoute();
       endpoints.MapRazorPages();
   });
    
app
    .Run();


