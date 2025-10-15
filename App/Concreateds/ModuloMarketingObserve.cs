using FirstProject.App.Contracts.Observer;
using FirstProject.App.Core;

namespace FirstProject.App.Concreateds;

class ModuloMarketingObserve : IPObserver<string>
{
    private static ModuloMarketingObserve? _instance;
    private ModuloMarketingObserve(){}
    private string _new = "";

    public static ModuloMarketingObserve Instance => _instance = new ModuloMarketingObserve();
    public void Update(string newState)
    {
        _new = newState;
        Log.Info("Modulo Marketing aggiornato: " + _new);
    }
}