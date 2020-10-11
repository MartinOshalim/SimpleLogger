using SimpleLogger.Logger;
using SimpleLogger.Logger.Interfaces;
using System;
using System.Threading;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace SimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoggerFactory = new LoggerFactory();

            ILogger nlogLogger = LoggerFactory.CreateNLogLogger();
            nlogLogger.Log(LogType.Trace, "Trace Message");
            nlogLogger.Log(LogType.Debug, "Debug Message");
            nlogLogger.Log(LogType.Info, "Info Message");
            nlogLogger.Log(LogType.Warn, "Warn Message");
            nlogLogger.Log(LogType.Error, "Error Message");
            nlogLogger.Log(LogType.Fatal, "Fatal Message");


            ILogger log4Net = LoggerFactory.CreateLog4NetLogger();
            log4Net.Log(LogType.Debug, "Debug Message");
            log4Net.Log(LogType.Info, "Info Message");
            log4Net.Log(LogType.Warn, "Warn Message");
            log4Net.Log(LogType.Error, "Error Message");
            log4Net.Log(LogType.Fatal, "Fatal Message");

            var loopCounter = 0;
            while (loopCounter < 5)
            {
                nlogLogger.Log(LogType.Error, "Error Message");
                log4Net.Log(LogType.Error, "Error Message");

                Thread.Sleep(10000);
                loopCounter++;
            }


        }
    }
}
