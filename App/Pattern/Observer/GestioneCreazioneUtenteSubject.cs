using FirstProject.App.Contracts.Observer;
using FirstProject.App.Entity;
using FirstProject.App.Pattern.Factory;

namespace FirstProject.App.Pattern.Observer;

class GestioneCreazioneUtenteSubject : IPSubject<string>
{
    private string _new = "";

    private string New
    {
        get => _new;
        set
        {
            _new = value; Notify();
        }
    }

    public void CreateUser(string name)
    {
        Utente user = UserFacotry.Create(name);
        New = user.ToString();
    }

    private List<IPObserver<string>> _obs = new List<IPObserver<string>>(); 
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
       foreach(var ob in _obs)
        {
            ob.Update(_new);
        }
    }
}