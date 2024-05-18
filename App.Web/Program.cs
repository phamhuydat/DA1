using App.Data;
using App.Data.Repositories;
using App.Web.WebConfig;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

builder.Services.AddApplicationServices(builder.Configuration, builder.Environment);

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

app.UseSession();
app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
        name: "login",
        pattern: "/login",
        defaults: new
        {
            controller = "Account",
            action = "Login"
        });

app.MapAreaControllerRoute(
        areaName: "Admin",
        name: "adminLogin",
        pattern: "/Admin/Login",
        defaults: new
        {
            controller = "Account",
            action = "Login",
            area = "Admin"
        });

app.MapControllerRoute(
        name: "error",
        pattern: "/error/{statusCode}",
        defaults: new
        {
            controller = "Home",
            action = "Error"
        });


app.MapAreaControllerRoute(
        areaName: "Admin",
        name: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
