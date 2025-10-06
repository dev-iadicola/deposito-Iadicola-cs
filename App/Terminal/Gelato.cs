#nullable disable
using FirstProject.App.Helpers.Array;
using FirstProject.App.IO;

namespace  FirstProject.App.Terminal;

class Gelato
{
    Dinamic<string> gelati;

    Dinamic<double> prezzi;

    public Gelato()
    {
        this.gelati = new Dinamic<string>();
        this.prezzi = new Dinamic<double>();

        exe();
    }


    public void exe()
    {

        string[] domandeNome = new string[5];
        string[] domandePrezzo = new string[5];

        for (int i = 0; i < 5; i++)
        {
            domandeNome[i] = $"Inserisci il nome del gelato #{i + 1}: ";
            domandePrezzo[i] = $"Inserisci il prezzo del gelato appena creato: ";
        }

        this.setGelati(domandeNome, domandePrezzo);
        this.printMenu();
    }

    public void setGelati(string[] questionNome, string[] questionPrezzo)
    {
        for (int i = 0; i < questionNome.Length; i++)
        {
            this.gelati.Add(IOutput.Make(questionNome[i]));
            this.prezzi.Add(IOutput.MakeDoble(questionPrezzo[i]));
        }

    }
    public void printMenu()
    {
        for (int i = 0; i < this.gelati.All().Length; i++)
        {
            Console.WriteLine($"Il Gelato {this.gelati.Get(i)} Ha il prezzo {this.prezzi.Get(i)} Euro");
         
        }
    }
}