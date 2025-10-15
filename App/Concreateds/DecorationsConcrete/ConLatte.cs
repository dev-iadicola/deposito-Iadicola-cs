using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Concreateds.DecorationsConcrete;
class ConLatte : DecoratoreBevanda
{
    public ConLatte(DecoratoreBevanda decBev) : base(decBev)
    {
        
    }
}