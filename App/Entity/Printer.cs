using System.Diagnostics;
using FirstProject.App.Contracts;

namespace FirstProject.App.Entity;

class Printer : IDispositiveE
{
	public string Modello { get; set; }

      public Printer(string Modello)
    {
        this.Modello = Modello;
    }
    public void TurnOff()
    {
        System.Console.WriteLine("The Printer is shutting down.");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The Printer turning on.");
    }
	public override string ToString()
	{
		// Return some information about the computer
		return $"Computer Model: {Modello}";
	}
}
