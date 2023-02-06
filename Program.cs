using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Keyboard_Cats.Data;
using Keyboard_Cats.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Keyboard_CatsContextConnection") ?? throw new InvalidOperationException("Connection string 'Keyboard_CatsContextConnection' not found.");

builder.Services.AddDbContext<Keyboard_CatsContext>(options =>
    options.UseSqlServer(connectionString));

//services builder for multiple roles.
/*builder.Services.AddIdentity<Keyboard_CatsUser, IdentityRole>().AddEntityFrameworkStores<Keyboard_CatsContext>().AddDefaultTokenProviders();*/

//initial services builder
builder.Services.AddDefaultIdentity<Keyboard_CatsUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Keyboard_CatsContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
