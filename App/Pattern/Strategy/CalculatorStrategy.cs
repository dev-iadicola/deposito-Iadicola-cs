using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FirstProject.App.Core;
using FirstProject.App.IO;

namespace FirstProject.App.Pattern.Strategy;

#region Interfaccia

// 1. Strategy: definisce l'interfaccia comune per tutti gli algoritmi
public interface IStrategyCalculator
{
    // Ad esempio, elaborare una lista di numeri in modi diversi
    double DoOperation(double a, double b);
}
#endregion

#region  Classi per il calcolo
// 2. ConcreteStrategyAdd: implementa la somma
public class Sum : IStrategyCalculator
{
    public double DoOperation(double a, double b)
    {
        return a + b;
    }
}

// 3. ConcreteStrategySubtract: implementa la sottrazione
public class Minus : IStrategyCalculator
{
    public double DoOperation(double a, double b)
    {
        return a - b;
    }
}

// 4. ConcreteStrategyMultiply: implementa la moltiplicazione
public class Multiply : IStrategyCalculator
{
    public double DoOperation(double a, double b)
    {
        return a * b;
    }
}

public class Division : IStrategyCalculator
{
    public double DoOperation(double a, double b)
    {
        if(b == 0)
        {
            Log.Error($"Non è possibile dividere {a} per 0");
            return 0;
        }
        else
        {
            return a / b;
        }
        
    }
}
#endregion

// 5. Context: utilizza una strategia per eseguire l'operazione
public class Context
{
    // Riferimento alla strategia corrente
    private IStrategyCalculator? _strategy;

    // Permette di cambiare strategia a runtime
    public void SetStrategy(IStrategyCalculator strategy)
    {
        _strategy = strategy;
    }

    // Esegue l'algoritmo tramite la strategia corrente
    public void ExecuteStrategy(double a, double b)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        double result = _strategy.DoOperation(a, b);
        Console.WriteLine($"Risultato dell'operazione: {result}");
    }
}

// 6. Client: configura il contesto e usa diverse strategie
public class CalcolatriceExe
{
    static bool exe = true;
    public static void Exe()
    {
        do
        {
            int scelta = IOutput.Make<int>("Calcolatrice. Scegli che operazione fare." +
        "\n1. Somma" +
        "\n2. Sottrazione" +
        "\n3. Moltiplicazione" +
        "\n4. Divisione" +
        "\n0. Esci");

            Facotry.Create(scelta, out exe);
        } while (exe);

    }

    #region Facotry 
    public class Facotry
    {
        public static void Create(int scelta, out bool exe)
        {
            exe = true;
            var context = new Context();
            switch (scelta)
            {
                case 1:
                    context.SetStrategy(new Sum());
                    Console.Write("Somma: "); break;
                case 2:
                    context.SetStrategy(new Minus());
                    Console.Write("Sottrazione: "); break;
                case 3:
                    context.SetStrategy(new Multiply());
                    Console.Write("Moltiplicazione: "); break;
                case 4:
                    context.SetStrategy(new Division());
                    Console.Write("Divisione: "); break;
                case 0: System.Console.WriteLine("In uscita");  exe = false; break;
                default: System.Console.WriteLine("Operazione non valida"); break;

            }
            IOutput io = new IOutput(["Seleziona primo numero", "Seleziona il secondo numero"]);
            context?.ExecuteStrategy(io.GetDouble(0), io.GetDouble(1));

        }


    }
    #endregion
}