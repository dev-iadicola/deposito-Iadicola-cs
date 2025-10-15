using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Concreateds.DecorationsConcrete;

class ConCioccolato :  DecoratorTorta
{
    public ConCioccolato(Itorta it) : base(it)
    {
    }

    public new string Descrizione()
    {
        return base.Descrizione() + " + Cioccolato ";
    }

   

}