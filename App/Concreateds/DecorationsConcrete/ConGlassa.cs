using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Concreateds.DecorationsConcrete;

class ConGlassa : DecoratorTorta
{
    public ConGlassa(Itorta i) : base(i)
    {
    }

      public new string Descrizione()
    {
        return base.Descrizione() + " + Glassa ";
    }

}