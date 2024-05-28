namespace FluentColoredConsole.Colors.WithBackground.WithForeground
{
    /// <summary>
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkBlue;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGreen;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkCyan;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkRed;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkMagenta;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkYellow;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Gray;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithDarkGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGray;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Blue;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Green;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Cyan;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Red;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Magenta;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Yellow;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
    /// Writes a black background with black foreground string to console.
    /// </summary>
    public class BlackWithWhite : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.White;
        private static ConsoleColor Background => ConsoleColor.Black;
    
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
