namespace FluentColoredConsole
{
    /// <summary>
    /// Represents a colored console writer.
    /// </summary>
    public interface IConsoleWriter
    {
        /// <summary>
        /// Writes a string to console without a new line.
        /// </summary>
        /// <param name="message">The string to write.</param>
        void Write(string message);

        /// <summary>
        /// Writes an object to console without a new line.
        /// </summary>
        /// <param name="message">The object instance to write.</param>
        void Write(object message);

        /// <summary>
        /// Writes a string to console and appends a new line.
        /// </summary>
        /// <param name="message">The string to write.</param>
        void WriteLine(string message);

        /// <summary>
        /// Writes an object to console and appends a new line.
        /// </summary>
        /// <param name="message">The object instance to write.</param>
        void WriteLine(object message);
    }
}
