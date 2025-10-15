using System.ComponentModel;
using FirstProject.App.Contracts.DecorationInterface;

namespace FirstProject.App.Pattern.Decorator;

abstract class DecoratoreBevanda : Ibevanda
{
    protected Ibevanda _iBevanda;
    public DecoratoreBevanda(Ibevanda iBevanda)
    {
        _iBevanda = iBevanda;
    }

    public double Costo()
    {
        return _iBevanda.Costo();
    }

    public string Descrizione()
    {
        return _iBevanda.Descrizione();
    }
}