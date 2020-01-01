using Microsoft.Extensions.Logging;
using System;

namespace EasyWeb.Logging
{
    public class Logger<T> where T: class
    {
        ILoggerFactory _loggerFctory = null;
        public ILoggerFactory LoggerFactory
        {
            get
            {
                if (_loggerFctory == null)
                    _loggerFctory = new LoggerFactory();
                return _loggerFctory;
            }
        }
        public ILogger CreateLogger() => LoggerFactory.CreateLogger<T>();
    }
}
