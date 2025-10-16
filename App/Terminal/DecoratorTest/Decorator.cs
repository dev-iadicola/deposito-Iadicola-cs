using System.Xml;
using FirstProject.App.Concreateds.DecorationsConcrete;
using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Core;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Terminal.DecoratorTest;

class Decorator
{
    public static void TestBevande()
    {

    }

    public static void TestTorte()
    {
        bool exit = true;
        Itorta tortaCioccolato = new TortaCioccolato();
        //  DecoratorTorta dc = new DecoratorTorta(tortaCioccolato);
        System.Console.WriteLine("Creazione torta al cicccolato");
        do
        {
            int output = IOutput.Make<int>($"Inserisci ingredienti per {tortaCioccolato.Descrizione()}." +
            "\n1. Inserisci Frutta" +
            "\n2. Inserisci Cioccolato" +
            "\n3. Inserisci Glassa" +
            "\n0. exit" +
            "\nIngrendiente: ");
            Itorta res;
            switch (output)
            {
                case 0: exit = false; break;
                case 1: res = new ConMacedonia(tortaCioccolato);
                System.Console.WriteLine(res.Descrizione());
                 break;
                case 3: res = new ConGlassa(tortaCioccolato); 
                System.Console.WriteLine(res.Descrizione());
                break;
                case 2: res = new ConCioccolato(tortaCioccolato); 
                System.Console.WriteLine(res.Descrizione());
                break;
                default: Log.Error("Input errato"); break;
            }

        } while (exit);
    }
    
   
}