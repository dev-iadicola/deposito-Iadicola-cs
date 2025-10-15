using FirstProject.App.Contracts;
using FirstProject.App.Core;
using FirstProject.App.Entity.Concrete;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Factory;
using FirstProject.App.Pattern.Singleton;

namespace FirstProject.App.Terminal;

class PatternTest()
{

    public static void FactoryVeicle()
    {
        var auto = VeicleFactory.Create("auto");
        var moto = VeicleFactory.Create("moto");
        var bike = VeicleFactory.Create("bike");
        var truck = VeicleFactory.Create("truck");
        //VeicleFactory.Create("truck");

        auto?.Start();
        bike?.Start();
        truck?.Start();
        moto?.Start();
    }

    public static void FacotryShape()
    {

        string shape = IOutput.Make<string>("Which shape do you want to draw?");
        IShape ishape = ShapeCrerator.Create(shape);
        ishape?.Draw();

    }

    public static void RegistraVeicoloTest()
    {
        string type = ""; // popolamento per selezionare tipo di veicolo
        bool exit = true; // boleano per ricevere fine del registro

        var register = RegistraVeicolo.GetIstance(); // Istnaza del registro dei veicoli

        do
        {
            int output = IOutput.Make<int>("Scegli tipo di veicolo:"
            + "\n 1. Moto\n 2.Auto\n 3.Camion");
            switch (output)
            {
                case 1: type = "bike"; break;
                case 2: type = "auto"; break;
                case 3: type = "truck"; break;
                case 0: exit = false; break;
                default: Log.Error("Non è presente nulla nel numero " + output); type = ""; break;
            }
            if (!string.IsNullOrEmpty(type)) // se è vuoto non procede all'inserimento nulla
            {
                InputSystem.printDecoration("lista veicoli", 1);
                var veicle = VeicleFactory.Create(type); // creazione del veicolo
                register.Add(veicle);
                register.Show();
                InputSystem.printDecoration("Fine", 0);

            }

        } while (exit);

    }


    public static void DispositiveTest()
    {
        bool exit = true; // boleano per ricevere fine del registro

        var register = ConfigSystem.GetInstance(); // Istnaza del registro dei veicoli

        do
        {
            Console.WriteLine(); // va a capo dopo l'input
            string key = IOutput.Make<string>("Chiave");
            string val = IOutput.Make<string>("Valore");
            register.Set(key, val);

            register.PrintMemories();

            System.Console.WriteLine("Imposta sistema, altrimenti esci con 0."); char scelta = Console.ReadKey().KeyChar;

            if (scelta == '0')
            {
                exit = false;
            }
        } while (exit);

    }
}