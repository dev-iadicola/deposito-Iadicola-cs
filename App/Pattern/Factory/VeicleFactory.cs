
using FirstProject.App.Contracts;
using FirstProject.App.Core;
using FirstProject.App.Entity.Concrete;
using FirstProject.App.Helpers.Array;

namespace FirstProject.App.Pattern.Factory;

class VeicleFactory{
    
    public static IVeicle? Create(string type)
    {
        // Dinamic<string> veicles = new Dinamic<string>(); //TODO: da implementare

        // veicles.Create(["auto", "bike", "truck"]);
        // if (veicles.Equals(type))
        // {
        //     return new  
        // }
        

        
        switch (type.ToLower())
        {
            case "auto": return new Auto();
            case "bike": return new Bike();
            case "truck": return new Truck();
            default:  Log.Error($"Class {type} not found! did you mean 'bike', 'truck' or 'auto'?"); return null;
        }
        
    }
}