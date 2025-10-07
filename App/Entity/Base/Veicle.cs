namespace FirstProject.App.Entity.Base;

public class Veicle
{
    public string brand;
    public string model;

    public Veicle(string brand, string model)
    {
        this.brand = brand; this.model = model;
    }

    public virtual void PrintInfo()
    {
        System.Console.WriteLine($"Brand: {this.brand}, Model: {this.model}");
    }

    public override string ToString()
    {
        return $" Brand: {this.brand}, Model: {this.model}";
    }

}
