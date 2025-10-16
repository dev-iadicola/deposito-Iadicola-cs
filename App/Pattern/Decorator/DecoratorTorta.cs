using System.ComponentModel;
using FirstProject.App.Contracts.DecorationInterface;

namespace FirstProject.App.Pattern.Decorator;

abstract class DecoratorTorta : Itorta
{
    protected Itorta _i;
    public DecoratorTorta(Itorta i)
    {
        _i = i;
    }

    public virtual string Descrizione()
    {
        return _i.Descrizione();
    }

   
   
}