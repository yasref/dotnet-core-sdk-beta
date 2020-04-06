namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        private static ILoggerFactory LoggerFactory => new LoggerFactory().AddLog4Net();

        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}