using GFTTeste1.Data;
using GFTTeste1.Data.Interfaces;
using GFTTeste1.Service;
using GFTTeste1.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace GFTTeste1
{
    class Program
    {
        static void Main(string[] args)
        {

            using IHost host = CreateHostBuilder(args).Build();

            ICategoryService tradeService = host.Services.GetRequiredService<ICategoryService>();

            Console.WriteLine("Hello World!");
            var Trade1 = new Trade(2000000, "Private");
            var Trade2 = new Trade(400000, "Public");
            var Trade3 = new Trade(500000, "Public");
            var Trade4 = new Trade(3000000, "Public");

            List<Trade>  portfolio = new List<Trade>();
            portfolio.Add(Trade1);
            portfolio.Add(Trade2);
            portfolio.Add(Trade3);
            portfolio.Add(Trade4);

            List<string> tradeCategories = tradeService.GetCategoriesToString(portfolio);

            Console.WriteLine("tradeCategories = {0}", string.Join(", ", tradeCategories));

        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureServices((_, services) =>
                   services.AddTransient<ICategoryService, CategoryService>()
                           .AddScoped<ITradeRepository, MemoryTradeRepository>());


    }
}
