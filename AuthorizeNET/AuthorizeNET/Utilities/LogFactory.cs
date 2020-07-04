namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        public static ILogger CustomLogger { get; set; }

        //private static ILoggerFactory LoggerFactory => new LoggerFactory().AddLog4Net();

        public static ILogger getLog(Type classType)
        {
            if(CustomLogger!=null)
                return CustomLogger;
            return new LoggerFactory().CreateLogger("AuthorizeNet");
            //return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}