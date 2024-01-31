using F12XA6_SOF_2023241.Logic;
using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Repository.Interfaces;
using F12XA6_SOF_2023241.Repository.Model_Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace F12XA6_SOF_2023241.Webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("AzureConnection") ??
                                   throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("F12XA6_SOF_2023241.Repository")));

            builder.Services.AddTransient<AppDbContext>();

            builder.Services.AddTransient<IRepository<Game>, GameRepository>();
            builder.Services.AddTransient<IRepository<Studios>, StudioRepository>();
            builder.Services.AddTransient<IRepository<Comment>, CommentRepository>();
            builder.Services.AddTransient<ICommentRepository, CommentRepository>();


            builder.Services.AddTransient<IGameLogic, GameLogic>();
            builder.Services.AddTransient<IStudioLogic, StudioLogic>();
            builder.Services.AddTransient<ICommentLogic, CommentLogic>();


            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<AppUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
          


            builder.Services.AddAuthentication().AddFacebook(opt =>
            {
                opt.AppId = "788936216400409";
                opt.AppSecret = "d91c741aa74729e2342795ffa8f35a54";
            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromMinutes(5);
            });

            builder.Services.AddTransient<IEmailSender, F12XA6_SOF_2023241.Logic.EmailSender>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
                app.UseMigrationsEndPoint();

            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.UseSession();

            app.Run();
        }
    }
}