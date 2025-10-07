using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using FirstProject.App.Entity;
using FirstProject.App.Entity.Base;
using FirstProject.App.IO;

namespace FirstProject.App.Terminal;

class Garage
{
    List<Veicle> veicleList;
    public Garage()
    {
        veicleList = new List<Veicle>();
        bool exit = true;
        do
        {
            Console.WriteLine("0.esci\n1. Aggiung moto\n2. Aggiungi Auto\n3. Stampa Lista dei veicoli");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0: exit = false; break;
                case 1:
                    IOutput res = new IOutput(["Inserisci Tipologia manubri", "Inserisci Marca", "Inserisci Modello"]);
                    veicleList.Add(new Bike(res.Get(0), res.Get(1), res.Get(2)));
                    break;
                case 2:
                    IOutput res2 = new IOutput(["Inserisci numero di porte", "Inserisci Marca", "Inserisci Modello"]);
                    veicleList.Add(new Macchina(res2.GetInt(0), res2.Get(1), res2.Get(2)));
                    break;

                case 3: this.PrintList(); break;
            }
        } while (exit);


    }
    private void PrintList()
    {
        foreach (var veicle in this.veicleList)
        {
            System.Console.WriteLine(veicle);
        }
    }
}