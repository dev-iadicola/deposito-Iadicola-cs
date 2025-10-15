using FirstProject.App.Contracts.DecorationInterface;

namespace FirstProject.App.Concreateds.DecorationsConcrete;

class Caffe : Ibevanda
{
    private double _costo = 0.60;

    private string descrizione = "Caffè";
    public double Costo()
    {
        return _costo;
    }

    public string Descrizione()
    {
        return "Descrizione: " + descrizione;
    }
}