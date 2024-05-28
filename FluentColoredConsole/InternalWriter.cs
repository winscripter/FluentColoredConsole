namespace FluentColoredConsole
{
    internal static class InternalWriter
    {
        public static void WriteColoredString(object str, ConsoleColor foreground)
        {
            string s = str.ToString() ?? string.Empty;
            var consoleForeground = Console.ForegroundColor;
            var consoleBackground = Console.BackgroundColor;

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = ConsoleColor.Black; // default
            Console.Write(s);

            Console.ForegroundColor = consoleForeground;
            Console.BackgroundColor = consoleBackground;
        }

        public static void WriteColoredStringLine(object str, ConsoleColor foreground)
        {
            string s = str.ToString() ?? string.Empty;
            var consoleForeground = Console.ForegroundColor;
            var consoleBackground = Console.BackgroundColor;

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = ConsoleColor.Black; // default
            Console.WriteLine(s);

            Console.ForegroundColor = consoleForeground;
            Console.BackgroundColor = consoleBackground;
        }

        public static void WriteColoredString(object str, ConsoleColor foreground, ConsoleColor background)
        {
            string s = str.ToString() ?? string.Empty;
            var consoleForeground = Console.ForegroundColor;
            var consoleBackground = Console.BackgroundColor;

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(s);

            Console.ForegroundColor = consoleForeground;
            Console.BackgroundColor = consoleBackground;
        }

        public static void WriteColoredStringLine(object str, ConsoleColor foreground, ConsoleColor background)
        {
            string s = str.ToString() ?? string.Empty;
            var consoleForeground = Console.ForegroundColor;
            var consoleBackground = Console.BackgroundColor;

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.WriteLine(s);

            Console.ForegroundColor = consoleForeground;
            Console.BackgroundColor = consoleBackground;
        }
    }
}
