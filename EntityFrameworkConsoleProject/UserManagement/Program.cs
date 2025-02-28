using UserManagement.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

Console.WriteLine("Con"+ builder.Configuration.GetConnectionString("ContosoPizza"));

builder.Services.AddDbContext<ContosoPizza2Context>(options =>
{
    options
    .UseLazyLoadingProxies()
    .UseSqlServer(builder.Configuration.GetConnectionString("ContosoPizza"));
});

var app = builder.Build();

/*using ContosoPizza2Context db = new ContosoPizza2Context();


List<User> users = db.Users.ToList();

foreach(var user in users)
{
    Console.WriteLine($"{user.Name}");
}*/


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
