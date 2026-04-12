using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using Task2_API.Data;
using Task2_API.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using Task2_API.MiddleWares;
using Task2_API.Filters;
namespace Task2_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllers(option => option.Filters.Add<ValidateJobFilter>());
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            //builder.Services.AddOpenApi();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server = .\\SQLEXPRESS;Database= Company; Integrated Security = True;trust server certificate = true"));
            builder.Services.AddScoped<IJobServices, JobService>();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<RegusetLoggerMiddleWares>();
            app.UseHttpsRedirection();
            app.UseExceptionHandler("/error"); // global error handling
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
//Data Source=.\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name="SQL Server Management Studio";Command Timeout=0