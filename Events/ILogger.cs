namespace EventsDelegates
{
    public enum LogMessageType
    {   
        Info,
        Error,
        Test
    }

    public interface ILogger
    {
        void Log(LogMessageType type, string text);
    }
}
