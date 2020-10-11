using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleLogger.Logger.Interfaces;

namespace SimpleLogger.Logger
{
    public class NLogLogger : IProgramaticLogger
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public NLogLogger()
        {
            //Can programatically configure logger rather than using the config file.
            //ConfigureLogger();
        }

        public void ConfigureLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();


            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile")
            {

                FileName = $"{DateTime.Now.ToString("dd-MM-yyyy")}.txt"
            };

            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);

            // Apply config           
            LogManager.Configuration = config;
        }

        public void Log(LogType logType, string errorMessage)
        {
            switch (logType)
            {
                case LogType.Trace:
                    _logger.Trace(errorMessage);
                    break;
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
