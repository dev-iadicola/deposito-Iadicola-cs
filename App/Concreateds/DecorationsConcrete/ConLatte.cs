using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Concreateds.DecorationsConcrete;
class ConLatte : DecoratoreBevanda
{
    public ConLatte(DecoratoreBevanda decBev) : base(decBev)
    {

    }

      public new string Descrizione()
    {
        return base.Descrizione() + " Panna ";
    }

    public new double Costo()
    {
        return base.Costo() + 0.20;
    }
    
}