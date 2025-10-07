using FirstProject.App.Entity.Base;

namespace FirstProject.App.Entity;

public class Bike : Veicle
{
    string? tipoManubri;
    public Bike(string tipoManubri, string brand, string model) : base(brand, model)
    {
        this.tipoManubri = tipoManubri;
    }

    public new void PrintInfo()
    {
        base.PrintInfo();
        System.Console.WriteLine($"La moto ha tipologia manubri : {this.tipoManubri}");
    }

    public override string ToString()
    {
        return $"Porte {tipoManubri} {base.ToString()}";
    }
}