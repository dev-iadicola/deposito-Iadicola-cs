using System.Xml;
using FirstProject.App.Concreateds.DecorationsConcrete;
using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Core;
using FirstProject.App.IO;

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
        System.Console.WriteLine("Creazione torta al cicccolato");
        do
        {
            int output = IOutput.Make<int>($"Inserisci ingredienti per {tortaCioccolato.Descrizione()}." +
            "\n1. Inserisci Frutta" +
            "\n2. Inserisci Cioccolato" +
            "\n3. Inserisci Glassa" +
            "0. exit");

            switch (output)
            {
                case 0: exit = false; break;
                case 1: tortaCioccolato = new ConMacedonia(tortaCioccolato); break;
                case 2: tortaCioccolato = new ConCioccolato(tortaCioccolato); break;
                case 3: tortaCioccolato = new ConGlassa(tortaCioccolato); break;
                default: Log.Error("Input errato"); break;
            }
            System.Console.WriteLine(tortaCioccolato.Descrizione());
            

        } while (exit);
    }
}