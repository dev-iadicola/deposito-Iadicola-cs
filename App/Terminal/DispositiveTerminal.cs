using FirstProject.App.Contracts;
using FirstProject.App.Entity;

namespace FirstProject.App.Terminal;

class DispositiveTerminal
{
    List<IDispositiveE> IDisps = new List<IDispositiveE>();
    public DispositiveTerminal()
    {
        this.IDisps.Add(new Computer("Asus"));
        this.IDisps.Add(new Printer("HP"));
        

        foreach(IDispositiveE Idisp in this.IDisps)
        {
            Idisp.TurnOn();
            System.Console.WriteLine(Idisp);
            Idisp.TurnOff();
        }

    }   
}