using FirstProject.App.Pattern.Singleton;

namespace FirstProject.App.Core;

class Log
{
    public static void Info(string message)
    {
        Logger.GetInstance().Message(message);
    }
    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Logger.GetInstance().Message(message);
        Console.ResetColor();
    }

    public static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Logger.GetInstance().Message(message);
        Console.ResetColor();
    }
}