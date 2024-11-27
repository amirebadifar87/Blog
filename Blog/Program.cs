using Core.Repositories;
using Core.Services;
using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DB_Context>(o=>o.UseSqlServer("Data Source =.;Initial Catalog=BlogDB;Integrated Security=true;TrustServerCertificate=True"));

builder.Services.AddScoped<DB_Context, DB_Context>();

builder.Services.AddTransient<IPostRepository, PostService>();
builder.Services.AddTransient<ICommentRepository, CommentService>();

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

app.Run();