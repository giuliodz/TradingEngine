﻿using System;
using System.Collections.Generic;
using System.Text;


namespace TradingEngineServer.Rejects
{
    public enum RejectionReason
    {
        Uknown,
        OrderNotFoound,
        InstrumentNotFound,
        AttemptingToModifyWrongSide
    }
}
