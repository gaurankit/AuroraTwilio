using AutoMapper;
using OrderPoolManager.Repositories;
using OrderPoolManager.Repositories.DBModels;
using OrderPoolManager.Services;
using OrderPoolManager.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;

namespace OrderPoolManager
{
    public class Program
    {
        private static string rootPath = System.IO.Path.GetDirectoryName(System.Environment.CommandLine.Split(' ')[0]) + "\\";
        private static IConfiguration config;
        public static void Main(string[] args)
        {
            var servicesProvider = BuildDi();
            var runner = servicesProvider.GetRequiredService<LogRunner>();
            var schedulerService = servicesProvider.GetRequiredService<OrderPoolManagerService>();
            runner.DoAction("Main Started");
            try
            {
                if (args.Length != 0 && args[0].Equals("REPORT"))
                {
                    //Create(args, runner, schedulerService).Wait();
                }
                runner.DoAction("Main End");
                NLog.LogManager.Shutdown();
            }
            catch (Exception ex)
            {
                runner.DoAction("Exception: " + ex.Message);
                runner.DoAction("Stack Trace: " + ex.StackTrace);
                Environment.ExitCode = 1;
            }
            Environment.ExitCode = 0;
        }

        private static IServiceProvider BuildDi()
        {
            var services = new ServiceCollection();
            services.AddTransient<LogRunner>();
            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            services.AddLogging((builder) => builder.SetMinimumLevel(LogLevel.Trace));
            //services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));
            services.AddDbContextPool<OrderContext>(options => options.UseSqlServer(config.GetConnectionString("OrderConnectionString")));
            services.AddTransient<OrderPoolManagerService>();
            services.AddSingleton<IOrderPoolManagerService, OrderPoolManagerService>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env}.json", optional: true)
                .Build();
            services.AddSingleton(config);

            var serviceProvider = services.BuildServiceProvider();
            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
            //configure NLog
            loggerFactory.AddNLog(new NLogProviderOptions { CaptureMessageTemplates = true, CaptureMessageProperties = true });

            if (!string.IsNullOrWhiteSpace(env))
            {
                NLog.LogManager.LoadConfiguration(rootPath + $@"\nlog.{env}.config");
            }
            else
            {
                NLog.LogManager.LoadConfiguration(rootPath + @"\nlog.config");
            }

            return serviceProvider;
        }
    }
}
