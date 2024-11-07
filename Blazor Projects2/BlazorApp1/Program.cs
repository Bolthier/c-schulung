using BlazorApp1;
using BlazorApp1.Components;
using BlazorApp1.Models;
using BlazorApp1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WortmannDbContext>();
builder.Services.AddScoped<Person>();

//builder.Services.AddSingleton<MyCounter>();
//builder.Services.AddScoped<IMyCounter, MyCounter2>();
//builder.Services.AddTransient<MyCounter>();

builder.MeldeCounterAlsScopedServiceAn<MyCounter>();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
