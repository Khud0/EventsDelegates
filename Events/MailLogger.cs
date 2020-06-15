using System;

namespace EventsDelegates
{
    class MailLogger : ILogger
    {
        public void Log(LogMessageType type, string text)
        {
            Console.WriteLine($"Email Sent: {text}");
        }
    }
}
