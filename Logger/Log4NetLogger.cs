using log4net;
using log4net.Config;
using SimpleLogger.Logger.Interfaces;
using System;
using System.IO;
using System.Reflection;

namespace SimpleLogger.Logger
{
    class Log4NetLogger : IProgramaticLogger
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public Log4NetLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.ConfigureAndWatch(logRepository, new FileInfo("log4net.config"));
        }

        public void ConfigureLogger()
        {
            throw new NotImplementedException();
        }

        public void Log(LogType logType, string errorMessage)
        {
            switch (logType)
            {
                case LogType.Debug:
                    _logger.Debug(errorMessage);
                    break;
                case LogType.Info:
                    _logger.Info(errorMessage);
                    break;
                case LogType.Warn:
                    _logger.Warn(errorMessage);
                    break;
                case LogType.Error:
                    _logger.Error(errorMessage);
                    break;
                case LogType.Fatal:
                    _logger.Fatal(errorMessage);
                    break;
            }
        }
    }
}
