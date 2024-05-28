namespace FluentColoredConsole.Colors.WithBackground.WithForeground
{
    /// <summary>
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithBlack : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Green;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkBlue;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkGreen : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGreen;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkCyan;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkRed;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkMagenta;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkYellow;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Gray;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithDarkGray : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.DarkGray;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithBlue : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Blue;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithCyan : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Cyan;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithRed : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Red;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithMagenta : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Magenta;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithYellow : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.Yellow;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
    /// Writes a green background with green foreground string to console.
    /// </summary>
    public class GreenWithWhite : IConsoleWriter
    {
        private static ConsoleColor Foreground => ConsoleColor.White;
        private static ConsoleColor Background => ConsoleColor.Green;
    
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
