using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Concreateds.DecorationsConcrete;

class ConMacedonia : DecoratorTorta
{
    public ConMacedonia(Itorta itorta) : base(itorta)
    {
    }

      public override string Descrizione()
    {
        return base.Descrizione() + " + Macedonia ";
    }

   
}