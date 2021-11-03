using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JsuPlus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string connectionstring = @"server=us-cdbr-east-04.cleardb.com;userid=b06d5d4e606035;password=8bdddad9;database=heroku_30ebef2574eacbe";
            //MySqlConnection connection = null;

            ////try
            ////{
            ////    connection= new MySqlConnection(connectionstring);
            ////    connection.Open();

                
            ////}

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
