using FirstProject.App.Contracts;
using FirstProject.App.Contracts.Observer;
using FirstProject.App.Core;

namespace FirstProject.App.Concreateds;

class ModuloLogObserve : IPObserver<string> 
{
    private string _new = "";

    private static ModuloLogObserve? _istance;
    private ModuloLogObserve() { }

    public static ModuloLogObserve Instance => _istance = new ModuloLogObserve();

    public void Update(string newState)
    {
        _new = newState;
        Log.Info("Modulo Log Aggiornato : " + _new);
    }
}