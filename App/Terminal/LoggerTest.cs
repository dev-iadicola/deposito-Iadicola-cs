using FirstProject.App.Pattern.Singleton;

namespace FirstProject.App.Terminal;

class LoggerTest
{

    Logger log1;
    Logger log2;

    public LoggerTest()
    {
        log1 = Logger.GetInstance();
        log2 = Logger.GetInstance();
        
        this.log1.Message("Questo è il test di log 1");
        this.log2.Message("Questo è il test di log 2");

        if (log1.GetHashCode() ==  log2.GetHashCode())
        {
            Console.WriteLine("Entrambe le chiamate appartengono alla stessa classe");
            Console.WriteLine($"HashCode log1: {log1.GetHashCode()} | HashCode log2: {log2.GetHashCode()}");
        } else
        {
            Console.WriteLine("Le chiamate appartengono a chiamate diverse");
            Console.WriteLine($"HashCode log1: {log1.GetHashCode()} | HashCode log2: {log2.GetHashCode()}");
        }
    }

}