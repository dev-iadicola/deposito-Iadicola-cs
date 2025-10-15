using FirstProject.App.Contracts.Observer;

namespace FirstProject.App.Pattern.Observer;

class CentroMeteoSubject : IPSubject<string>
{

    private readonly List<IPObserver<string>> _obs = new List<IPObserver<string>>();

    private string _dati = "";

    public string Dati
    {
        get => _dati;
        set
        {
            _dati = value;
            Notify();
        }
    }
    public void Attach(IPObserver<string> observer)
    {
        _obs.Add(observer);
    }

    public void Detach(IPObserver<string> observer)
    {
        _obs.Remove(observer);
    }

    public void Notify()
    {
       foreach (var ob in _obs)
        {
            ob.Update(_dati);
        }
    }
}





    

