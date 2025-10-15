using FirstProject.App.Contracts.Observer;

namespace FirstProject.App.Pattern.Observer;

class ConcreateSubject : ISubject 
{
    private readonly List<IObserver> _obs = new List<IObserver>();

    private int _state;

    // rendere modificabile _state
    public int State
    {
        get => _state;
        set
        {
            _state = value;
            Notify();
        }
    }
    public void Attach(IObserver iobs)
    {
        _obs.Add(iobs);
    }

    public void Detach(IObserver iobs)
    {
        _obs.Remove(iobs);
    }

    public void Notify()
    {
        foreach (var ob in _obs)
        {
            ob.Update(_state);
        }
    }
    
    
}