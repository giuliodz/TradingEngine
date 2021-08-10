using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer() => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
        {
            // Start with configuration - set the Host service to be a TradingEngineServer.
            services.AddOptions();
            services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));

            // Addd singleton objects.
            services.AddSingleton<ITrandingEngineServer, TradingEngineServer>();

            //Add Hosted service 
            services.AddHostedService<TradingEngineServer>();
        }).Build();

    }
}
