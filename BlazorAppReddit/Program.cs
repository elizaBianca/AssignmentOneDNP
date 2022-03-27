
// this is the configuration of your project

using BlazorAppReddit.Authentication;
using BlazorAppReddit.Data;
using Domain.DataAccessContracts;
using FileData.DaoObjects;
using FileData.DataAccess;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<FileContext>();
builder.Services.AddScoped<IRegisterDao, UserDao>();
builder.Services.AddScoped<ILoginDao, UserDao>();
builder.Services.AddScoped<IPostDao, PostDao>();
builder.Services.AddScoped<IPostDao, PostDao>();
builder.Services.AddScoped<AuthenticationStateProvider, SimpleAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthServiceImplement>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();