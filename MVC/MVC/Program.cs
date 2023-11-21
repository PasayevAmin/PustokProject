using Microsoft.EntityFrameworkCore;
using MVC.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PustokDbContext>(
    opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    }
    );


var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");

app.Run();
