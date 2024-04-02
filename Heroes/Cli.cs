namespace Heroes;

public static class Cli
{
    private static void Print(string msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(msg);
        Console.ResetColor();
    }
    
    private static void PrintLine(string msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Green);
    }
    
    public static void PrintWarning(string message)
    {
        PrintLine(message, ConsoleColor.Yellow);
    }
    
    public static void PrintError(string message)
    {
        PrintLine(message, ConsoleColor.Red);
    }
}