using Business.IOC.Microsoft;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddCustomDependencies(builder.Configuration);
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
{
    opt.Cookie.HttpOnly = true;
    opt.Cookie.Name = "CvCookie";
    opt.Cookie.SameSite = SameSiteMode.Strict; //lax: diðer web sayfalarýna cookie kullanýmý açýlmýþ olur. strict: kapatmýþ oluruz
    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
    opt.ExpireTimeSpan = TimeSpan.FromDays(15);
    opt.LoginPath = new PathString("/Auth/Login");
});

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=Index}/{id?}");
});

app.Run();
