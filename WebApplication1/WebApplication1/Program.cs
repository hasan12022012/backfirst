var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
    );



//app.MapGet("/test", () => "BMW");

//app.MapGet("/test", () =>
//{
//    return "BMW";
//});

app.Run();
