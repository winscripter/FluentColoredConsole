namespace FluentColoredConsole.Colors.WithBackground
{
    /// <summary>
    /// Writes a blue string to console.
    /// </summary>
    public class Blue : IConsoleWriter
    {
        private static ConsoleColor Foreground => Console.ForegroundColor;
        private static ConsoleColor Background => ConsoleColor.Blue;

        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);

        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);

        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);

        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }
}