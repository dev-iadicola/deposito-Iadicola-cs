using System.Diagnostics;
using FirstProject.App.Contracts;

namespace FirstProject.App.Entity;

class Computer : IDispositiveE
{
	public string Modello { get; set; }

    public Computer(string Modello)
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
