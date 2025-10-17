namespace FirstProject.ProgettoFinale;

#region AppContext Singleton
public sealed class AppContext
{
    private static AppContext? _instance;

    // oggetto di lock per sicurezza in multi-thread
    private static readonly object _lock = new();

    // proprietà globali
    public string Currency { get; private set; }
    public decimal Iva { get; private set; }
    public decimal BaseDiscount { get; private set; }

    // per evitare reinizializzazioni
    private bool _initialized = false;

    // costruttore privato
    private AppContext() { }

    // proprietà di accesso globale
    public static AppContext Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AppContext();
                }
            }
            return _instance;
        }
    }

    // metodo di inizializzazione una sola volta
    public void Initialize(string currency, decimal iva, decimal baseDiscount)
    {
        if (_initialized)
            throw new InvalidOperationException("AppContext è già stato inizializzato.");

        Currency = currency;
        Iva = iva;
        BaseDiscount = baseDiscount;

        _initialized = true;
    }
}
#endregion

#region Logger Singleton

public class Logger
{
    private static Logger? _instance;
    private static readonly object _lock = new();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Logger();
            }
        }
    }

    public void Info(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now:HH:mm:ss} - {message}");
    }

    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARNING] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public void Log(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public void UI(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"[UI] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }


}
#endregion

#region  Static Log for 
public class Log
{
    public static void Info(string message)
    {
        Logger.Instance.Log(message);
    }

    public static void UI(string message)
    {
        Logger.Instance.UI(message);
    }

    public static void Warning(string message)
    {
        Logger.Instance.Warning(message);
    }

    public static void Error(string message)
    {
        Logger.Instance.Error(message);
    }


}
#endregion



