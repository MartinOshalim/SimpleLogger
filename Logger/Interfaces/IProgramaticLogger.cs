using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogger.Logger.Interfaces
{
    public interface IProgramaticLogger : ILogger
    {
        public void ConfigureLogger();
    }
}
