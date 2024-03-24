using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApi.Models;
using BookStoreApi.Services;
using Microsoft.Extensions.Options;


namespace BookStoreApi
{
    public class Program
    {


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        // No Idea how the tutorial wants me to fit in this code. 


        //var builder = WebApplication.CreateBuilder(args);

        //// Add services to the container.
        //builder.Services.Configure<BookStoreDatabaseSettings>(
        //    builder.Configuration.GetSection("BookStoreDatabase"));

        //builder.Services.AddSingleton<BooksService>();

        //builder.Services.AddControllers()
        //.AddJsonOptions(
        //    options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

        //app.UseDefaultFiles();
        //app.UseStaticFiles();

    }
}
