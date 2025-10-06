namespace FirstProject.App.IO;

using System.Runtime.InteropServices;
using FirstProject.App.IO;
using FirstProject.App.Helpers;
using System.Runtime.InteropServices.Swift;
using System;

class InputSystem
{
    public static string? readLine;


    public static dynamic sumInput(string question1 = "", string question2 = "", bool positive = true)
    {
        Console.Write(question1);
        string? a = Console.ReadLine();

        Console.Write(question2);
        string? b = Console.ReadLine();

        int intNumb = Casting.stringToInt(a);
        float floatNumb = Casting.stringToFloat(b);

        while (positive && (intNumb < 0 || floatNumb < 0))
        {
            Console.Write(positive);
            Console.WriteLine("Inserisci numeri positivi");
            Console.Write(question1);
            a = Console.ReadLine();
            Console.Write(question2);
            b = Console.ReadLine();
            intNumb = Casting.stringToInt(a ?? "0");
            floatNumb = Casting.stringToFloat(b);
        }

        return Calc.sum(intNumb, floatNumb);
    }

    public static string[] GenerateIO(string[] questions)
    {
        string[] response = new string[questions.Length];
        for (int i = 0; i < questions.Length; i++)
        {
            Console.Write(questions[i]+" ");
            response[i] = Console.ReadLine() ?? "No response";
        }

        return response;
    }

    

    public static bool isAdult()
    {
        string? ageStr = Console.ReadLine();


        int age = Casting.stringToInt(ageStr);

        while (age < 0)
        {
            Console.WriteLine("Inserisci un'età valida");
            ageStr = Console.ReadLine();
            age = Casting.stringToInt(ageStr);
        }
        readLine = ageStr;
        return Calc.isMajorThan(age, 17);
    }


    public static void printLine(string message)
    {
        Console.WriteLine(message+" ");
    }

    public static void print(string message)
    {
        Console.Write(message);
    }


    




}