# FluentColoredConsole
![stars](https://img.shields.io/github/stars/winscripter/FluentColoredConsole)
![type](https://img.shields.io/badge/type-colored_console-blue)

Write barely any C# code only to print text in foreground/background color to console!

Many colors were auto-generated to save up time.

FluentColoredConsole is a way to provide one-liner way to write text or objects to console
with a specific background or foreground color, and you barely have to write anything...

FluentColoredConsole keeps the previous console colors after printing something.

### Example
Example app is the FluentColoredConsole.TestApp project:
```cs
using CC = FluentColoredConsole.ColoredConsole;

Console.ForegroundColor = ConsoleColor.Red;

CC.Green.Write("Welcome to ");
CC.Background.Text.White.Green.Write("FluentColoredConsole");
Console.Write('!');
```

![screenshot](https://github.com/winscripter/FluentColoredConsole/assets/142818255/265e3b7c-9289-4082-99b1-abba0baf820f)

