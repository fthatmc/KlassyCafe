using KlassyCafe.DAL.Context;
using KlassyCafe.Services.AboutUsImageServices;
using KlassyCafe.Services.AboutUsServices;
using KlassyCafe.Services.CategoryServices;
using KlassyCafe.Services.ProductServices;
using KlassyCafe.Services.SliderServices;
using KlassyCafe.Services.VideoServices;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// nosql baðlantý konfigürasyonu
var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<KlassyContext>(opt =>
{
    opt.UseNpgsql(connectionstring);
});

builder.Services.AddScoped<IAboutUsImageService, AboutUsImageService>();
builder.Services.AddScoped<IAboutUsServices, AboutUsServices>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();
builder.Services.AddScoped<IProductServices, ProductServices>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IVideoService, VideoService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //AutoMapper konfigürasyonu

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
