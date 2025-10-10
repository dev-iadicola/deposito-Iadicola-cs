using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using FirstProject.App.Entity;
using FirstProject.App;
using FirstProject.App.Helpers.Array;
using FirstProject.App.Helpers.Str;
using FirstProject.App.IO;
using FirstProject.App.Terminal;
using FirstProject.App.Entity.Base;

class Program
{
    static void Main()
    {


        //DinamicTest dtest = new DinamicTest();
        // dtest.UnsetKeyTest();
        // dtest.UnsetByValueTest();
        // dtest.TestRemoveDuplicate();
        // dtest.TestAddArray();
        // dtest.AddTest();
        // dtest.SorterTest();
        // dtest.SorterRevert();

        // new Gelato();

        // User user = new User("Mario", "29");
        // User user2 = new User("Luca", "28");

        // //  UserTerminal userT = new UserTerminal(user);
        // //  UserTerminal userT2 = new UserTerminal(user2);

        // // userT.Saluta();
        // //  userT2.Saluta();
        // float[] votes = [2, 3, 4, 5];
        // float[] votes2 = [2, 6, 5, 6];
        // var st1 = new StudetTerminal(new Student(user, votes));
        // var st2 = new StudetTerminal(new Student(user2, votes2));

        // st2.Print();


        // BookTerminal bt = new BookTerminal();
        // bt.equalsTest();
        // bt.print();

        // Macchina macchina = new Macchina(new User("Luca", 10), "V8", "Sportive", 300);
        // macchina.motore = "V12";
        // macchina.velocità = 300;
        // macchina.velocità = 300;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 700;
        // macchina.velocità = 300;

        // new VideoTecaTerminal();

        // new Garage();

        new DispositiveTerminal();


    }

    static void pg86()
    {
        string str = "Paolo ha salutato";
        println($"Lettere: {StringManipulation.Analyze(str, 'c')}"); // 1 p, 4 a, 2 t

        println($"Stringa senza spazi: {StringManipulation.Analyze(str)}");
        println($"Conta vocali: {StringManipulation.Analyze(str, true)}");
        println($"Conta consonanti: {StringManipulation.Analyze(str, false)}");
    }
    static void countVocalInString()
    {
        Console.WriteLine("Inserisci una stringa che contenga vocali per contarli\n");
        int count = StringManipulation.CountVocal(Console.ReadLine()?? "nothing");
        Console.WriteLine($"Vocali trovate {count}");
    }
    static void deleteSpaceInString()
    {
        IOutput io = new IOutput(["Inserisci una stringa con spazi e questi saranno eliminati\n"]);

        Console.WriteLine($"La tua stringa senza spazi: {StringManipulation.RemoveSpaces(io.Get(0))}");
    }
    static void countNumberInString()
    {
        IOutput io = new IOutput(["Inserisci una frace con dei numeri e l'algorito conterà i numeri presenti nella stringa\n"]);
        string stringa = io.Get(0);
        int count = 0;
        foreach (char c in stringa)
        {
            if (char.IsDigit(c))
                count++;
        }

        Console.WriteLine($"Sono presenti {count} cifre nella stringa");
    }

    static void moltiplaction()
    {
        IOutput io = new IOutput(["Numero da Moltiplocare", "Moltiplica per quante volte?"]);
        int num = io.GetInt(0);
        int per = io.GetInt(1);
        int[] tabella = Calc.tabellaMoltiplicazioni(num, per);
        for (int i = 0; i < tabella.Length; i++)
        {
            Console.WriteLine(tabella[i] + "\n");
        }
    }
    static void bankOperation()
    {
        Console.Write("Seleziona Operazione:\n1. Visualizza Saldo\n2. Deposita Denaro\n 3.Preleva\n 4.Esci");

        ConsoleKeyInfo keyInfo;

        BankAccount bankAccount = new BankAccount();
        BankTerminal bankTerminal = new BankTerminal(bankAccount);
        do
        {
            keyInfo = Console.ReadKey(true);

            // cifra scelta dall'utente

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    bankTerminal.showBalance();
                    break;

                case ConsoleKey.D2:
                    bankTerminal.DepositOperation();
                    break;

                case ConsoleKey.D3:
                    bankTerminal.WithdrawOperation();

                    break;

                case ConsoleKey.D4:
                    Console.WriteLine("\nUscita dal programma...");
                    break;

                default:
                    Console.WriteLine("\nTasto non valido, riprova.");
                    break;
            }
        } while (keyInfo.Key != ConsoleKey.D4);

    }


    static void passwordReq()
    {
        User user = new User();
        UserTerminal ut = new UserTerminal(user);
        do
        {
            // esegue IO per password, se la password è corretta la prop. passwordCorrect diventa true, altrimenti loginAttempts diminuisce di 1.
            ut.sendRequestLogin();
        } while (ut.user.loginAttempts > 0 && !ut.passwordCorrect);
    }

    static void print(string message)
    {
        InputSystem.print(message);
    }

    static void println(string message)
    {
        InputSystem.printLine($"\n{message}\n");
    }
}
