using System.ComponentModel;
using FirstProject.App.Concreateds.DecorationsConcrete;
using FirstProject.App.Contracts.DecorationInterface;
using FirstProject.App.Core;
using FirstProject.App.Entity;
using FirstProject.App.Entity.Concrete;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Pattern.Factory;

class TortaFactory
{
    private Itorta tortaCioccolato;

    public static DecoratorTorta? Create(int output, Itorta tortaCioccolato, out bool exit)
    {
        exit = true;
        switch (output)
        {
            case 0: exit = false; return null;
            case 1: return new ConMacedonia(tortaCioccolato);
            case 3: return new ConGlassa(tortaCioccolato);
            case 2: return new ConCioccolato(tortaCioccolato);
            default: Log.Error("Input errato"); return null;
        }
    }
}