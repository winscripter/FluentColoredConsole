using FluentColoredConsole.Colors;
using FluentColoredConsole.Colors.WithBackground.WithForeground;

namespace FluentColoredConsole
{
#pragma warning disable CS1591
    /// <summary>
    /// Provides methods to write colored text to the console.
    /// </summary>
    public static class ColoredConsole
    {
        public static class Background
        {
            public static class Text
            {
                public static class Black
                {
                    public static IConsoleWriter DarkBlue { get; set; } = new BlackWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new BlackWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new BlackWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new BlackWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new BlackWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new BlackWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new BlackWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new BlackWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new BlackWithBlue();
                    public static IConsoleWriter Green { get; set; } = new BlackWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new BlackWithCyan();
                    public static IConsoleWriter Red { get; set; } = new BlackWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new BlackWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new BlackWithYellow();
                    public static IConsoleWriter White { get; set; } = new BlackWithWhite();
                }

                public static class DarkBlue
                {
                    public static IConsoleWriter Black { get; set; } = new DarkBlueWithBlack();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkBlueWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkBlueWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkBlueWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkBlueWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkBlueWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkBlueWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkBlueWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkBlueWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkBlueWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkBlueWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkBlueWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkBlueWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkBlueWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkBlueWithWhite();
                }

                public static class DarkGreen
                {
                    public static IConsoleWriter Black { get; set; } = new DarkGreenWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkGreenWithDarkBlue();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkGreenWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkGreenWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkGreenWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkGreenWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkGreenWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkGreenWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkGreenWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkGreenWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkGreenWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkGreenWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkGreenWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkGreenWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkGreenWithWhite();
                }

                public static class DarkCyan
                {
                    public static IConsoleWriter Black { get; set; } = new DarkCyanWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkCyanWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkCyanWithDarkGreen();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkCyanWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkCyanWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkCyanWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkCyanWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkCyanWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkCyanWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkCyanWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkCyanWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkCyanWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkCyanWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkCyanWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkCyanWithWhite();
                }

                public static class DarkRed
                {
                    public static IConsoleWriter Black { get; set; } = new DarkRedWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkRedWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkRedWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkRedWithDarkCyan();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkRedWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkRedWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkRedWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkRedWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkRedWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkRedWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkRedWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkRedWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkRedWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkRedWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkRedWithWhite();
                }

                public static class DarkMagenta
                {
                    public static IConsoleWriter Black { get; set; } = new DarkMagentaWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkMagentaWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkMagentaWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkMagentaWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkMagentaWithDarkRed();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkMagentaWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkMagentaWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkMagentaWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkMagentaWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkMagentaWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkMagentaWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkMagentaWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkMagentaWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkMagentaWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkMagentaWithWhite();
                }

                public static class DarkYellow
                {
                    public static IConsoleWriter Black { get; set; } = new DarkYellowWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkYellowWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkYellowWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkYellowWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkYellowWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkYellowWithDarkMagenta();
                    public static IConsoleWriter Gray { get; set; } = new DarkYellowWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new DarkYellowWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkYellowWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkYellowWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkYellowWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkYellowWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkYellowWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkYellowWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkYellowWithWhite();
                }

                public static class Gray
                {
                    public static IConsoleWriter Black { get; set; } = new GrayWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new GrayWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new GrayWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new GrayWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new GrayWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new GrayWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new GrayWithDarkYellow();
                    public static IConsoleWriter DarkGray { get; set; } = new GrayWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new GrayWithBlue();
                    public static IConsoleWriter Green { get; set; } = new GrayWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new GrayWithCyan();
                    public static IConsoleWriter Red { get; set; } = new GrayWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new GrayWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new GrayWithYellow();
                    public static IConsoleWriter White { get; set; } = new GrayWithWhite();
                }

                public static class DarkGray
                {
                    public static IConsoleWriter Black { get; set; } = new DarkGrayWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new DarkGrayWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new DarkGrayWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new DarkGrayWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new DarkGrayWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new DarkGrayWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new DarkGrayWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new DarkGrayWithGray();
                    public static IConsoleWriter Blue { get; set; } = new DarkGrayWithBlue();
                    public static IConsoleWriter Green { get; set; } = new DarkGrayWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new DarkGrayWithCyan();
                    public static IConsoleWriter Red { get; set; } = new DarkGrayWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new DarkGrayWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new DarkGrayWithYellow();
                    public static IConsoleWriter White { get; set; } = new DarkGrayWithWhite();
                }

                public static class Blue
                {
                    public static IConsoleWriter Black { get; set; } = new BlueWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new BlueWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new BlueWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new BlueWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new BlueWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new BlueWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new BlueWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new BlueWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new BlueWithDarkGray();
                    public static IConsoleWriter Green { get; set; } = new BlueWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new BlueWithCyan();
                    public static IConsoleWriter Red { get; set; } = new BlueWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new BlueWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new BlueWithYellow();
                    public static IConsoleWriter White { get; set; } = new BlueWithWhite();
                }

                public static class Green
                {
                    public static IConsoleWriter Black { get; set; } = new GreenWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new GreenWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new GreenWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new GreenWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new GreenWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new GreenWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new GreenWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new GreenWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new GreenWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new GreenWithBlue();
                    public static IConsoleWriter Cyan { get; set; } = new GreenWithCyan();
                    public static IConsoleWriter Red { get; set; } = new GreenWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new GreenWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new GreenWithYellow();
                    public static IConsoleWriter White { get; set; } = new GreenWithWhite();
                }

                public static class Cyan
                {
                    public static IConsoleWriter Black { get; set; } = new CyanWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new CyanWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new CyanWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new CyanWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new CyanWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new CyanWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new CyanWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new CyanWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new CyanWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new CyanWithBlue();
                    public static IConsoleWriter Green { get; set; } = new CyanWithGreen();
                    public static IConsoleWriter Red { get; set; } = new CyanWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new CyanWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new CyanWithYellow();
                    public static IConsoleWriter White { get; set; } = new CyanWithWhite();
                }

                public static class Red
                {
                    public static IConsoleWriter Black { get; set; } = new RedWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new RedWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new RedWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new RedWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new RedWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new RedWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new RedWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new RedWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new RedWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new RedWithBlue();
                    public static IConsoleWriter Green { get; set; } = new RedWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new RedWithCyan();
                    public static IConsoleWriter Magenta { get; set; } = new RedWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new RedWithYellow();
                    public static IConsoleWriter White { get; set; } = new RedWithWhite();
                }

                public static class Magenta
                {
                    public static IConsoleWriter Black { get; set; } = new MagentaWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new MagentaWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new MagentaWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new MagentaWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new MagentaWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new MagentaWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new MagentaWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new MagentaWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new MagentaWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new MagentaWithBlue();
                    public static IConsoleWriter Green { get; set; } = new MagentaWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new MagentaWithCyan();
                    public static IConsoleWriter Red { get; set; } = new MagentaWithRed();
                    public static IConsoleWriter Yellow { get; set; } = new MagentaWithYellow();
                    public static IConsoleWriter White { get; set; } = new MagentaWithWhite();
                }

                public static class Yellow
                {
                    public static IConsoleWriter Black { get; set; } = new YellowWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new YellowWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new YellowWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new YellowWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new YellowWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new YellowWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new YellowWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new YellowWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new YellowWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new YellowWithBlue();
                    public static IConsoleWriter Green { get; set; } = new YellowWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new YellowWithCyan();
                    public static IConsoleWriter Red { get; set; } = new YellowWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new YellowWithMagenta();
                    public static IConsoleWriter White { get; set; } = new YellowWithWhite();
                }

                public static class White
                {
                    public static IConsoleWriter Black { get; set; } = new WhiteWithBlack();
                    public static IConsoleWriter DarkBlue { get; set; } = new WhiteWithDarkBlue();
                    public static IConsoleWriter DarkGreen { get; set; } = new WhiteWithDarkGreen();
                    public static IConsoleWriter DarkCyan { get; set; } = new WhiteWithDarkCyan();
                    public static IConsoleWriter DarkRed { get; set; } = new WhiteWithDarkRed();
                    public static IConsoleWriter DarkMagenta { get; set; } = new WhiteWithDarkMagenta();
                    public static IConsoleWriter DarkYellow { get; set; } = new WhiteWithDarkYellow();
                    public static IConsoleWriter Gray { get; set; } = new WhiteWithGray();
                    public static IConsoleWriter DarkGray { get; set; } = new WhiteWithDarkGray();
                    public static IConsoleWriter Blue { get; set; } = new WhiteWithBlue();
                    public static IConsoleWriter Green { get; set; } = new WhiteWithGreen();
                    public static IConsoleWriter Cyan { get; set; } = new WhiteWithCyan();
                    public static IConsoleWriter Red { get; set; } = new WhiteWithRed();
                    public static IConsoleWriter Magenta { get; set; } = new WhiteWithMagenta();
                    public static IConsoleWriter Yellow { get; set; } = new WhiteWithYellow();
                }
            }

            public static IConsoleWriter Black { get; set; } = new Colors.WithBackground.Black();
            public static IConsoleWriter Blue { get; set; } = new Colors.WithBackground.Blue();
            public static IConsoleWriter Cyan { get; set; } = new Colors.WithBackground.Cyan();
            public static IConsoleWriter DarkBlue { get; set; } = new Colors.WithBackground.DarkBlue();
            public static IConsoleWriter DarkCyan { get; set; } = new Colors.WithBackground.DarkCyan();
            public static IConsoleWriter DarkGray { get; set; } = new Colors.WithBackground.DarkGray();
            public static IConsoleWriter DarkGreen { get; set; } = new Colors.WithBackground.DarkGreen();
            public static IConsoleWriter DarkMagenta { get; set; } = new Colors.WithBackground.DarkMagenta();
            public static IConsoleWriter DarkRed { get; set; } = new Colors.WithBackground.DarkRed();
            public static IConsoleWriter DarkYellow { get; set; } = new Colors.WithBackground.DarkYellow();
            public static IConsoleWriter Gray { get; set; } = new Colors.WithBackground.Gray();
            public static IConsoleWriter Green { get; set; } = new Colors.WithBackground.Green();
            public static IConsoleWriter Magenta { get; set; } = new Colors.WithBackground.Magenta();
            public static IConsoleWriter Red { get; set; } = new Colors.WithBackground.Red();
            public static IConsoleWriter White { get; set; } = new Colors.WithBackground.White();
            public static IConsoleWriter Yellow { get; set; } = new Colors.WithBackground.Yellow();
        }

        public static IConsoleWriter Black { get; set; } = new Black();
        public static IConsoleWriter Blue { get; set; } = new Blue();
        public static IConsoleWriter Cyan { get; set; } = new Cyan();
        public static IConsoleWriter DarkBlue { get; set; } = new DarkBlue();
        public static IConsoleWriter DarkCyan { get; set; } = new DarkCyan();
        public static IConsoleWriter DarkGray { get; set; } = new DarkGray();
        public static IConsoleWriter DarkGreen { get; set; } = new DarkGreen();
        public static IConsoleWriter DarkMagenta { get; set; } = new DarkMagenta();
        public static IConsoleWriter DarkRed { get; set; } = new DarkRed();
        public static IConsoleWriter DarkYellow { get; set; } = new DarkYellow();
        public static IConsoleWriter Gray { get; set; } = new Gray();
        public static IConsoleWriter Green { get; set; } = new Green();
        public static IConsoleWriter Magenta { get; set; } = new Magenta();
        public static IConsoleWriter Red { get; set; } = new Red();
        public static IConsoleWriter White { get; set; } = new White();
        public static IConsoleWriter Yellow { get; set; } = new Yellow();
    }
#pragma warning restore CS1591
}
