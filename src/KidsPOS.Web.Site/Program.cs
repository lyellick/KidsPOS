using KidsPOS.Common.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration["DefaultConnection"];

builder.Services
        .AddRazorPages()
        .AddRazorRuntimeCompilation()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });

builder.Services
        .AddDbContext<KidsPOSContext>(options => options.UseLazyLoadingProxies().UseSqlite(connectionString))
        .AddSingleton(builder.Configuration);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error")
        .UseHsts();
}

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting();

app.MapRazorPages();

IServiceScope scope = app.Services.CreateScope();
KidsPOSContext context = scope.ServiceProvider.GetService<KidsPOSContext>();
await context.Database.EnsureCreatedAsync();

app.Run();
