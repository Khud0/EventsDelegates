using System;

namespace EventsDelegates
{
    class NotificationLogger : ILogger
    {
        public void Log(LogMessageType type, string text)
        {
            Console.WriteLine($"Notification: {text}");
        }
    }
}
