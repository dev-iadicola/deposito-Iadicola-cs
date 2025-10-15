using FirstProject.App.Contracts.Observer;
using FirstProject.App.Core;

namespace FirstProject.App.Concreateds;

class DisplayMobileObserve : IPObserver<string>
{
    private string _obsDati = "";
    public void Update(string newState)
    {
        _obsDati = newState; 
        Log.Info("Il disp. Mobile ha ricevouto un aggiornamento: " + _obsDati);
    }
}