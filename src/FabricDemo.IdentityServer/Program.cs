﻿using Creekdream.Configuration.Apollo;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog.Web;

namespace FabricDemo.IdentityServer
{
    /// <inheritdoc />
    public class Program
    {
        /// <inheritdoc />
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <inheritdoc />
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (hostingContext, builder) =>
                    {
                        builder.AddApollo(builder.Build().GetSection("apollo"));
                    })
                .UseStartup<Startup>()
                .UseNLog();
    }
}
