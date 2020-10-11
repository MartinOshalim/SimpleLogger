namespace SimpleLogger.Logger.Interfaces
{
    public interface ILogger
    {
        void Log(LogType logType, string errorMessage);
    }
}