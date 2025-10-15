
using System.Diagnostics;
using FirstProject.App.Contracts;
using FirstProject.App.Entity.Concrete;

namespace FirstProject.App.Entity;

class Computer : Dispositive
{
	public new string Modello { get; set; }

    public Computer(string Modello = "Basic PC")
    {
        this.Modello = Modello;
    }
    public override void TurnOff()
    {
        System.Console.WriteLine("The computer is shutting down.");
    }

    public override void TurnOn()
    {
        System.Console.WriteLine("The computer turning on.");
    }
	public override string ToString()
	{
		// Return some information about the computer
		return $"Computer Model: {Modello}";
	}
}
