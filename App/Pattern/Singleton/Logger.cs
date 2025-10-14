using FirstProject.App.Contracts;

namespace FirstProject.App.Pattern.Singleton;

class Logger : ISingleton
{
    private static Logger? log;
    private Logger() { }

    private List<string>? messages;
    public static Logger GetInstance()
    {
        if (log == null)
        {
            log = new Logger();
        }
        return log;
    }

    public void Message(string message)
    {
        Console.WriteLine($"{message} - {this.datetimeRome()}");
    }

    public string datetimeRome()
    {
        // Get the current UTC time
        DateTime utcNow = DateTime.UtcNow;

        // Convert UTC time to Rome time
        TimeZoneInfo romeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
        DateTime romeTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, romeTimeZone);

        // Format the date and time
        string formattedDate = romeTime.ToString("dd/MM/yyyy HH:mm:ss");
        return $"UTC in Rome: {formattedDate}";
    } 

    public void Log(string message)
    {
        messages?.Add(message);
    }
      






}