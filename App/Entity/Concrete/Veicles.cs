using System.Net.WebSockets;
using FirstProject.App.Contracts;
using FirstProject.App.Core;
using FirstProject.App.Helpers.Array;

namespace FirstProject.App.Entity.Concrete;

abstract class Veicle : IVeicle
{
    public virtual void Start()
    {
        Log.Error("Emplementazione errata, manca override");
    }
    public virtual void ShowTyep()
    {
        Log.Error("Emplementazione errata, manca override");

    }


}
class Auto : Veicle
{
    public override void Start() => System.Console.WriteLine("Avvio dell'auto");

    public override void ShowTyep() => System.Console.WriteLine("Tipo Auto");


}

class Bike : Veicle
{
    public override void Start() => System.Console.WriteLine("Avvio della moto");

    public override void ShowTyep() => System.Console.WriteLine("Tipo Auto");

}
class Truck : Veicle
{
    public override void Start() => System.Console.WriteLine("Avvio del camion");

    public override void ShowTyep() => System.Console.WriteLine("Tipo Camion");
}


class RegistraVeicolo : ISingleton
{
    private static RegistraVeicolo? _istance;

    private List<Veicle> veicles = new List<Veicle>();

    private RegistraVeicolo(){}
    public static RegistraVeicolo GetIstance()
    {
        _istance = new RegistraVeicolo();
        return _istance;
    }

    public void Add(Veicle veicle)
    {   
        veicles.Add(veicle);
    }

    public void Show()
    {
        int count = 1;
        foreach(Veicle ve in this.veicles)
        {
            System.Console.WriteLine($"{count++} ");
            ve.ShowTyep();
        }
    }
}