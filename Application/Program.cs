using Application.Infrastructure;
using Application.LineBot;
using Application.LineLiff;
using Application.Web;
using Microsoft.AspNetCore.Mvc.Razor;

#region Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddOptions();
builder.Services.Configure<RazorViewEngineOptions>(o => o.ViewLocationFormats.Clear());
builder.Services.AddWeb();
builder.Services.AddLiff();
builder.Services.AddBot(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);

#endregion

#region Configure the HTTP request pipeline.
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStatusCodePages();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
#endregion
