using System.Diagnostics;

namespace RGIS.Logging;
public static class Logger
{
    public static bool Enabled { get; set; } = true;

    public static bool TimeStamp { get; set; } = true;

    public static bool showReference { get; set; } = true;

    public static bool showMessage { get; set; } = true;

    public static bool showLongMessage { get; set; } = true;

    public static string connector { get; set; } = " ";

    public static ConsoleColor error { get; set; } = ConsoleColor.Red;

    public static ConsoleColor debug { get; set; } = ConsoleColor.Cyan;

    public static ConsoleColor warning { get; set; } = ConsoleColor.Yellow;

    public static ConsoleColor regular { get; set; } = ConsoleColor.Green;

    public static void Warn(string reference, string message, string longMessage)
    {
        Out(warning, "WARNING", reference, message, longMessage);
    }

    public static void Log(string reference, string message, string longMessage)
    {
        Out(regular, "LOGGING", reference, message, longMessage);
    }

    public static void Debug(string reference, string message, string longMessage)
    {
        Out(debug, "  DEBUG", reference, message, longMessage);
    }

    public static void Error(string reference, string message, string longMessage)
    {
        Out(error, "  ERROR", reference, message, longMessage);
    }

    private static void Out(ConsoleColor color, string mode, string reference, string message, string longMessage)
    {
        if(Enabled)
        {
            string OutString = mode;
            Console.ForegroundColor = color;
            if (TimeStamp)
            {
                OutString += connector + Stopwatch.GetTimestamp().ToString();
            }
            if(showReference)
            {
                OutString += connector + reference;
            }
            if (showMessage)
            {
                OutString += connector + message;
            }
            if (showLongMessage)
            {
                OutString += connector + longMessage;
            }
                Console.WriteLine(OutString);

            
        }
    }
}
