using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Core;

using var engine = TradingEngineServerHostBuilder.BuildTradingEngineServer();
TradingEngineServerServiceProvider.ServiceProvider = engine.Services;
{
    using var sccope = TradingEngineServerServiceProvider.ServiceProvider.CreateScope();
    await engine.RunAsync().ConfigureAwait(false);
}