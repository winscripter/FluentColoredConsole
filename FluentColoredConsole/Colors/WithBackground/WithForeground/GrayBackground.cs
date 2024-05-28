namespace FluentColoredConsole.Colors.WithBackground.WithForeground
{
    /// <summary>
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithBlack : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Gray;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkBlue;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGreen;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkCyan;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkRed;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkMagenta;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkYellow;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithDarkGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGray;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Blue;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Green;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Cyan;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Red;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Magenta;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Yellow;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
    /// Writes a gray background with gray foreground string to console.
    /// </summary>
    public class GrayWithWhite : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.White;
        private static ConsoleColor Background => ConsoleColor.Gray;
    
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
