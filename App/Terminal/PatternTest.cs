using FirstProject.App.Contracts;
using FirstProject.App.Entity.Concrete;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Factory;

namespace FirstProject.App.Terminal;

class PatternTest()
{

    public static void FactoryVeicle()
    {
        var auto = VeicleFactory.Create("auto");
        var moto = VeicleFactory.Create("moto");
        var bike = VeicleFactory.Create("bike");
        var truck = VeicleFactory.Create("truck");
        //VeicleFactory.Create("truck");

        auto?.Start();
        bike?.Start();
        truck?.Start();
        moto?.Start();
    }

    public static void FacotryShape()
    {

        string shape = IOutput.Make<string>("Which shape do you want to draw?");
        IShape ishape = ShapeCrerator.Create(shape);
        ishape?.Draw(); 

    }
}