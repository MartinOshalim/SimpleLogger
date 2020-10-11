using SimpleLogger.Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleLogger.Logger
{
    public class LoggerFactory
    {
        public IProgramaticLogger CreateNLogLogger()
        {
            return new NLogLogger();
        }

        public IProgramaticLogger CreateLog4NetLogger()
        {
            return new Log4NetLogger();
        }
    }
}
