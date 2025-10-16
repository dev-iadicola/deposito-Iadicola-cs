using System.Xml;
using FirstProject.App.Concreateds.DecorationsConcrete;
using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Core;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Decorator;
using FirstProject.App.Pattern.Factory;

namespace FirstProject.App.Terminal.DecoratorTest;

class DecoratorTest
{
    public static void TestBevande()
    {

    }

    public static void Torte()
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
            Itorta res = TortaFactory.Create(output, tortaCioccolato, out exit);

            System.Console.WriteLine(res?.Descrizione());
            

        } while (exit);
    }
    
   
}