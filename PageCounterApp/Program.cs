using PageCounterApp.Services; // This is added because we need the service namespace for IPageCounterService.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // This will add support for controllers and views.
builder.Services.AddSingleton<IPageCounterService, PageCounterService>(); // I added this to register the page counting service as a singleton.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // This is added because it shows a custom error page in non-development mode.
    app.UseHsts(); // This will add HTTP Strict Transport Security (HSTS) for better security.
}

app.UseHttpsRedirection(); // I added this to ensure all HTTP requests are redirected to HTTPS.
app.UseStaticFiles(); // This is added because we want to serve static files like CSS or JavaScript.

app.UseRouting(); // This will set up the routing middleware.
app.UseAuthorization(); // I think this is for handling authorization if we use it later.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // This is added to define the default route for the app.

app.Run(); // This will start the application.
