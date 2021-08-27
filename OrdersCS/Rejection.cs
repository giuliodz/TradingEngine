﻿using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Rejects
{
    public class Rejection : IOrderCore
    {
        public Rejection (IOrderCore rejectedOrder, RejectionReason rejectionReason)
        {
            _orderCore = rejectedOrder;
            RejectionReason = rejectionReason;
        }
        // PROPERTIES //
        public RejectionReason RejectionReason;
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // FIELDS //
        private readonly IOrderCore _orderCore;
    }
}
