using System;

namespace TradingEngineServer.Orders
{
    public class IOrderCore
    {
        public long OrderId { get; set; }
        public string Username { get; }
        public int SecurityId { get; }
    }
}
