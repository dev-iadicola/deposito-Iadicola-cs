using System.Diagnostics;
using FirstProject.App.Contracts;
using FirstProject.App.Entity.Concrete;

namespace FirstProject.App.Entity;

class Computer : Dispositive
{
	public string Modello { get; set; }

    public Computer(string Modello = "Basic PC")
    {
        this.Modello = Modello;
    }
    public void TurnOff()
    {
        System.Console.WriteLine("The computer is shutting down.");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The computer turning on.");
    }
	public override string ToString()
	{
		// Return some information about the computer
		return $"Computer Model: {Modello}";
	}
}
