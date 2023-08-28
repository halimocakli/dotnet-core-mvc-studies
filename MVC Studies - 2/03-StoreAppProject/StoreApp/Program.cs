using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

// MVC yapısını kullanabilmek için ihtiyaç duyduğumuz servisi builder'a ekliyoruz.
builder.Services.AddControllersWithViews();

// Database iletişimi için DbContext servis kaydımızı oluşturuyoruz.
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});

// Servisleri inşa ediyoruz, yani uygulamayı ayağa kaldırıyoruz.
var app = builder.Build();

// MapGet ile ilerlenen rotaya göre içerik iletimi yapıyoruz.
// MapPost, MapPut, MapDelete gibi Minimal Api metodları mevcuttur.
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/turkcell", () => "Turkcell Akademi");

// Middleware
app.UseStaticFiles();   // wwwroot klasörünün kullanılabilir hale gelmesini sağlar.
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
