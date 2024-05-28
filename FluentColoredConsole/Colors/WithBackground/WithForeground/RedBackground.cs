namespace FluentColoredConsole.Colors.WithBackground.WithForeground
{
    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithBlack : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Red;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkBlue;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGreen;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkCyan;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkRed;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkMagenta;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkYellow;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Gray;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithDarkGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGray;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Blue;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Green;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Cyan;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Magenta;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Yellow;
        private static ConsoleColor Background => ConsoleColor.Red;
    
        /// <inheritdoc cref="IConsoleWriter.Write(string)" />
        public void Write(string message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.Write(object)" />
        public void Write(object message) => InternalWriter.WriteColoredString(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(string)" />
        public void WriteLine(string message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    
        /// <inheritdoc cref="IConsoleWriter.WriteLine(object)" />
        public void WriteLine(object message) => InternalWriter.WriteColoredStringLine(message, Foreground, Background);
    }

    /// <summary>
    /// Writes a red background with red foreground string to console.
    /// </summary>
    public class RedWithWhite : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.White;
        private static ConsoleColor Background => ConsoleColor.Red;
    
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
