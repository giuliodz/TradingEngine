﻿using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Logging;

namespace TradingEngine.Logging
{
    public class LoggerConfiguration
    {
        public LoggerType LoggerType { get; set; }
        public TextLoggerConfiguration TextLoggerConfiguration { get; set; }
    }

    public class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string FilenameExtension { get; set; }
        public string Filename { get; set; }
    }

}