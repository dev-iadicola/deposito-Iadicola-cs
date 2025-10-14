using FirstProject.App.Contracts;

namespace FirstProject.App.Entity.Concrete;

class Auto : IVeicle
{
    public void Start() => System.Console.WriteLine("Avvio dell'auto");

    public void ShowTyep() => System.Console.WriteLine("Tipo Auto");

}

class Bike : IVeicle
{
    public void Start() => System.Console.WriteLine("Avvio della moto");

    public void ShowTyep() => System.Console.WriteLine("Tipo Auto");

}
class Truck : IVeicle
{
    public void Start() => System.Console.WriteLine("Avvio del camion");

    public void ShowTyep() => System.Console.WriteLine("Tipo Camion");
}