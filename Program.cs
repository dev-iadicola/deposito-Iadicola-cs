using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using FirstProject.App;
using FirstProject.App.Entity;
using FirstProject.App.Helpers.Array;
using FirstProject.App.Helpers.Str;
using FirstProject.App.IO;
using FirstProject.App.Terminal;

class Program
{
    static void Main()
    {
        //     Console.WriteLine($"La somma di 3 + 4 ={Calc.sum(3, 4)}");
        //     Console.WriteLine($"La somma di 3.4 + 4.4 ={Calc.sum(3.4, 4.4)}");
        //     Console.WriteLine($"Lo sconto di 100 è stato applicato {Calc.discount(100, 20)}");
        //     if (Calc.isPositiveFloat(1.99f))
        //     {
        //         Console.WriteLine("Il numero è positivo");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Il numero è negativo");
        //     }

        //     // Domanda di svolgere somma tra un int e un float    
        //     float inpFloat = InputSystem.sumInput("Inserisci un numero intero:", "Inserisci un numero decimale:");
        //     Console.WriteLine("somma " + inpFloat);
        //     // Domanda di svolgere somma tra un int e un float   

        //    float inpFloat2 = InputSystem.sumInput("Inserisci il tuo peso:", "Inserisci la tua altezza:"); 
        //     Console.WriteLine("somma " + inpFloat2);

        // // Questionario Età
        // Console.WriteLine("Sei maggiorenne? Scrivi la tua età: ");
        // Console.WriteLine(InputSystem.isAdult() ? "Sei Maggiorenne" : "Non sei Maggiorennne" + "\nEtà inserita: " + InputSystem.readLine);

        // // Inserisci sconto applicato 10%
        // Console.WriteLine("Inserisci il prezzo di un prodotto da scontale al 10%. ");
        // string? price = Console.ReadLine();
        // float floatPrice = Casting.stringToFloat(price);


        // float discounted = Calc.discount(floatPrice, 10);
        // if (discounted > 100)
        //     Console.WriteLine("Prezzo scontato: " + discounted + " Euro");


        // // media di tre numeri 
        // int[] numbers = new int[3];
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine("Inserisci il " + (i + 1) + " voto: ");
        //     string? number = Console.ReadLine();
        //     numbers[i] = Casting.stringToInt(number);
        // }

        // float media = Calc.agv(numbers);
        // string result = (media >= 60) ? "Esame Superato" : " Esito Negativo";

        // Console.WriteLine(result + "La tua media è: " + media);

        // Calcolo BMI
        // string[] responses = InputSystem.GenerateQuestionary(new string[] { "Quanto pesi (Kg)", "Quanto sei alto (metri)" });

        // float kg = Casting.stringToFloat(responses[0]);
        // float metri = Casting.stringToFloat(responses[0]);
        // float bmi = Calc.BMI(kg, metri);
        // Console.WriteLine("Il tuo BMI è: " + bmi);
        // if (bmi < 18.5)
        //     Console.WriteLine("Sei sottopeso");
        // else if (bmi >= 18.5 && bmi < 24.9)
        //     Console.WriteLine("Hai un peso normale");
        // else if (bmi >= 25 && bmi < 29.9)
        //     Console.WriteLine("Sei sovrappeso");
        // else
        //     Console.WriteLine("Sei obeso");

        // string[] response = InputSystem.GenerateIO(new string[] { "Inserisci numeri interi positivi" });

        // int num = Casting.stringToInt(response[0]);
        // int sum = 0;

        // while (num >= 0)
        // {
        //     sum += num;
        //     Console.WriteLine("Somma attuale: " + sum);

        //     response = InputSystem.GenerateIO(new string[] { "Inserisci numeri interi positivi\n" });
        //     num = Casting.stringToInt(response[0]);
        // }

        // Console.WriteLine("La somma è: " + sum);


        // // Indovina Il numero
        // IOutput io = new IOutput(["Indovina il numero"]);


        // int guessNumber = 5;

        // int requestNumber = io.GetIntResponse(0);

        // while (requestNumber != guessNumber)
        // {

        //     Console.WriteLine(
        //         $"Il numero è {(guessNumber < requestNumber ? "minore" : "maggiore")}"
        //     );
        //     request = new IOutput(["Indovina il numero"]);
        //     requestNumber = request.GetIntResponse(0);
        // }
        // Console.Write("Hai Indovinato!");

        // Simulazione Sportello Bancario




        // bankOperation();

        // Password pg. 57
        // passwordReq();

        //moltiplaction();

        // Capitolo Foreach pg.68
        //countNumberInString();
        // deleteSpaceInString();
        //countVocalInString();

        //pg.86 
        //pg86()
        //pg87
        // RandomTerminal.GuessNumber(1,10);

        //pg.113
        // ESERCIZIO INSERIMENTO VOTI
        // StudetTerminal terminal = new StudetTerminal();
        // terminal.SetVotes();
        // terminal.student.Print();

        // Esercizio Lista Spesa

        // UserTerminal terminal = new UserTerminal();
        // terminal.Shopping();

        //114

        DinamicTest dtest = new DinamicTest();
        // dtest.UnsetKeyTest();
        // dtest.UnsetByValueTest();
        // dtest.TestRemoveDuplicate();
        // dtest.TestAddArray();
        // dtest.AddTest();
        dtest.SorterTest();
        dtest.SorterRevert();
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
        int count = StringManipulation.CountVocal(Console.ReadLine());
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
