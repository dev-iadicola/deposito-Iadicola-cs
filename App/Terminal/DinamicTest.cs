using FirstProject.App.Helpers.Array;
using FirstProject.App.IO;

namespace FirstProject.App.Terminal;

class DinamicTest
{

    Dinamic<int> dinamic = new Dinamic<int>();





    void Exe()
    {
        Dinamic<int> intArray = new Dinamic<int>();
        InputSystem.printLine("Crea una lista di numeri interi");
        IOutput io = new IOutput(["N1", "N2", "N3", "n4", "n5"]);

        intArray.Create(io.AllInt());

        foreach (int num in intArray.All())
        {
            Console.WriteLine(num);
        }
        io = new IOutput(["Aggiungi unaltro numero: "]);

        intArray.Add(io.GetInt(0));
        System.Console.WriteLine("dopo Push");
        foreach (int num in intArray.All())
        {
            Console.WriteLine(num);
        }
        io = new IOutput(["Rimuovi un indice, es 0 o 1"]);
        intArray.Unset(io.GetInt(0));
        System.Console.WriteLine("dopo Unset");
        foreach (int num in intArray.All())
        {
            Console.WriteLine(num);
        }


        io = new IOutput(["Scrivi un numero che esiste opppure no"]);

        System.Console.WriteLine($"Il valore esiste?: {intArray.ValueExist(io.GetInt(0))}");


        io = new IOutput(["Rimuovi un valore esistente"]);

        intArray.UnsetByValue(io.GetInt(0));

        foreach (int num in intArray.All())
        {
            Console.WriteLine(num);
        }

    }

    public void UnsetKeyTest()
    {
        System.Console.WriteLine("Test UnsetKey");
        this.dinamic = new Dinamic<int>();
        this.dinamic.Create([1, 23, 4, 5, 6, 9, 6, 4, 52, 3, 4]);
        this.dinamic.Unset(3);
        this.dinamic.Print();
    }

    public void TestRemoveDuplicate()
    {
        System.Console.WriteLine("Test RemoveDuplicate");
        this.dinamic = new Dinamic<int>();
        this.dinamic.Create([1, 23, 4, 4, 5, 6, 9, 6, 4, 52, 3, 4, 5]);
        dinamic.RemoveDuplicate();
        dinamic.Print();


    }

    public void TestAddArray()
    {
        System.Console.WriteLine("Test Add con firma di Array");
        this.dinamic.Create([1]);
        this.dinamic.Add([5, 6]);
        this.dinamic.Print();
    }


    public void AddTest()
    {
        System.Console.WriteLine("Test Add con firma singola");
        this.dinamic.Create([1]);
        this.dinamic.Add(2);
        this.dinamic.Add(2);
        this.dinamic.Add(2);
        this.dinamic.Print();
    }

    public void UnsetByValueTest()
    {
        System.Console.WriteLine("Test UnsetByValue");
        this.dinamic = new Dinamic<int>();
        this.dinamic.Create([1, 23, 4, 4, 4, 4, 4, 4, 4, 5, 6, 9, 6, 4, 52, 3, 4]);
        this.dinamic.UnsetByValue(4);
        this.dinamic.Print();
    }

    public void SorterTest()
    {
        this.dinamic = new Dinamic<int>();
        this.dinamic.Create([3, 1, 4, 2]);
        this.dinamic.Sort();
        this.dinamic.Print();
    }

     public void SorterRevert()
    {
        this.dinamic = new Dinamic<int>();
        this.dinamic.Create([3, 1, 4, 2]);
        this.dinamic.SortRevert();
        this.dinamic.Print();
    }

}









