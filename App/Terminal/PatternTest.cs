using FirstProject.App.Contracts;
using FirstProject.App.Core;
using FirstProject.App.Entity.Concrete;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Factory;

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
            if (!string.IsNullOrEmpty(type)) // se è vuoto non riporta nulla
            {
                var veicle = VeicleFactory.Create(type); // creazione del veicolo
                register.Add(veicle);
                register.Show();
            }

        } while (exit);

    }
}