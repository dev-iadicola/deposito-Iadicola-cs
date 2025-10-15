using System.Diagnostics;
using FirstProject.App.Contracts;
using FirstProject.App.Entity.Concrete;

namespace FirstProject.App.Entity;

class Printer : Dispositive
{
	public new string Modello { get; set; }

    public Printer(string Modello = "Basic Printer")
    {
        this.Modello = Modello;
    }
    

    public override void TurnOff()
    {
        System.Console.WriteLine("The Printer is shutting down.");
    }

    public override void TurnOn()
    {
        System.Console.WriteLine("The Printer turning on.");
    }
	public override string ToString()
	{
		// Return some information about the computer
		return $"Computer Model: {Modello}";
	}
}
