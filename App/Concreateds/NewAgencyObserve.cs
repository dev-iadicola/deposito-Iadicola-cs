using FirstProject.App.Contracts.Observer;
using FirstProject.App.Core;

namespace FirstProject.App.Concreateds; 

class NewAgencyObserve : IPObserver<string>
{
     private string _new = "";
    public void Update(string newState)
    {
        _new = newState; 
        Log.Info("Nuova News: " + _new);
    }
}