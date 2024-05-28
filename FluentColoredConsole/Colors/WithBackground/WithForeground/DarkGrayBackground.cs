namespace FluentColoredConsole.Colors.WithBackground.WithForeground
{
    /// <summary>
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithBlack : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGray;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkBlue;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGreen;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkCyan;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkRed;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkMagenta;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithDarkYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkYellow;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Gray;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Blue;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Green;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Cyan;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Red;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Magenta;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Yellow;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
    /// Writes a dark gray background with dark gray foreground string to console.
    /// </summary>
    public class DarkGrayWithWhite : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.White;
        private static ConsoleColor Background => ConsoleColor.DarkGray;
    
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
