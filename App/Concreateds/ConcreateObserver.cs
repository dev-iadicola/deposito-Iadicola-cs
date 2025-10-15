using FirstProject.App.Contracts.Observer;

namespace FirstProject.App.Concreateds;

class ConcreateObserver : IObserver
{
    private readonly string _name;

    private int _observerState;

    public ConcreateObserver(string name)
    {
        _name = name;
    }

    // Viene chiamato dal Subject 
    public void Update(int newState)
    {
        _observerState = newState;
        Console.WriteLine($"{_name} ha ricevuto aggiornamento, stato ={_observerState}");
    }

}