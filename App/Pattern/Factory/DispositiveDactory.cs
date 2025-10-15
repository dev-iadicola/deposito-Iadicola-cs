using System.ComponentModel;
using FirstProject.App.Core;
using FirstProject.App.Entity;
using FirstProject.App.Entity.Concrete;

namespace FirstProject.App.Pattern.Factory;

class DispositiveFactory
{
   public static Dispositive? Create(string type)
    {
         switch (type.ToLower())
        {
            case "pc": return new Computer();
            case "print": return new Printer();
            default:  Log.Error($"Class {type} not found! did you mean 'pc' or 'print'?"); return null;
        }
    }
}