using FirstProject.App.Contracts;

namespace FirstProject.App.Entity.Concrete;

abstract class Dispositive : IDispositiveE
{
    public string Modello { get; set; }

    public virtual void TurnOn(){}
    public virtual void TurnOff(){}
    public virtual string ToString()
    {
        return "Dispositive not found";
    }
}
