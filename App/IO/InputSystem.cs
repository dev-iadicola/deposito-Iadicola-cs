namespace FirstProject.App.IO;

using System.Runtime.InteropServices;
using FirstProject.App.IO;
using FirstProject.App.Helpers;
using System.Runtime.InteropServices.Swift;
using System;

class InputSystem
{
    /// <summary>
    /// Stores the latest input line read from the user as a nullable string.
    /// </summary>
    public static string readLine = string.Empty ;
    public static string[] GenerateIO(string[] questions)
    {
        string[] response = new string[questions.Length];
        for (int i = 0; i < questions.Length; i++)
        {
            Console.Write(questions[i]+" ");
            response[i] = Console.ReadLine() ?? "0";
        }

        return response;
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