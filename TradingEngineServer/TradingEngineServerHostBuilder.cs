using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

using TradingEngine.Logging;
using TradingEngineServer.Core.Configuration;



namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((hostContext, services)
                =>
            {
                // Start with configurations.
                services.AddOptions();
                services.Configure<TradingEngineServerConfiguration>(hostContext.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));
                services.Configure<LoggerConfiguration>(hostContext.Configuration.GetSection(nameof(LoggerConfiguration)));

                // Add singleton objects.
                services.AddSingleton<ITextLogger, TextLogger>();
                services.AddSingleton<ITrandingEngineServer, TradingEngineServer>();

                // Add hosted service.
                services.AddHostedService<TradingEngineServer>();
            }).Build();

    }
}
