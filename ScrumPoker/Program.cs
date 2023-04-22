using ScrumPoker.Controllers;
using ScrumPoker.Helpers;
using ScrumPoker.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IGameHelper, GameHelper>();
builder.Services.AddSingleton<ICardHelper, CardHelper>();
builder.Services.AddMemoryCache();
builder.Services.AddSignalR();
builder.Services.AddScoped<IGameController, GameController>();

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
app.MapHub<ScrumPokerHub>("/scrumPokerHub");

app.Run();

