using Accounting.Core.Services.Interfaces;
using Accounting.Core.Services.Interfaces.ServicesClass;
using Accounting.Core.Services.ServicesClass;
using Accounting.DataLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc();

#region Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
});

#endregion


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

#region Data Context

builder.Services.AddDbContext<AccountingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountingConnection")));

#endregion

#region IOC

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ITransactionsService, TransactionsService>();

#endregion

var app = builder.Build();
app.UseRouting();
app.MapStaticAssets();

app.MapRazorPages().WithStaticAssets();
    
app.UseAuthentication();
app.UseStaticFiles();
app.MapRazorPages();

app.UseHttpsRedirection();


app.UseAuthorization();



app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();