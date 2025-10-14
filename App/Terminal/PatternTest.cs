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
}