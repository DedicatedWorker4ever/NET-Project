using CbsStudents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container. This must be before the .build()
builder.Services.AddDbContext<CbsStudentsContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudentsContext")));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddDefaultUI()
.AddEntityFrameworkStores<CbsStudentsContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline. If we are in development we will show exceptions which allows us to debug easier. Otherwise it will just redirect us to a error page.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//all middleware. The order is very important since it resolves in order
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
