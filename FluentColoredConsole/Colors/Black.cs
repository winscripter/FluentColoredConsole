﻿namespace FluentColoredConsole.Colors
{
    /// <summary>
    /// Writes a black string to console.
    /// </summary>
    public class Black : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Black;
        private static ConsoleColor Background => Console.BackgroundColor;

        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground);

        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground);

        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground);

        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground);
    }
}