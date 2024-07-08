var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //mvc template introduced
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
//controller/action/id?
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
