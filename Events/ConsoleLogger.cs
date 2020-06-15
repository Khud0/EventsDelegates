using System;

namespace EventsDelegates
{
    class ConsoleLogger: ILogger
    {
        public ConsoleColor defaultColor = ConsoleColor.DarkCyan;
        private readonly ConsoleColor errorColor = ConsoleColor.DarkRed;
        private readonly ConsoleColor infoColor = ConsoleColor.White;

        #region Constructors
        public ConsoleLogger()
        {
            // Create an empty space in the console whenever a new logger is initialized
            Console.WriteLine();
        }
        public ConsoleLogger(ConsoleColor defaultTextColor)
            : this()
        {
            this.defaultColor = defaultTextColor;   
        }
        #endregion

        public void Log(LogMessageType type, string text)
        {
            Console.ForegroundColor = GetMessageColor(type);
            Console.WriteLine($"{type}: {text}");
            Console.ForegroundColor = defaultColor;
        }

        private ConsoleColor GetMessageColor(LogMessageType type)
        {
            switch (type)
            {
                case LogMessageType.Error:
                    return errorColor;

                case LogMessageType.Info:
                    return infoColor;

                default:
                    Log(LogMessageType.Error, $"No color is specified for LogMessageType {type}!");
                    return defaultColor;
            }
        }   
    }
}
