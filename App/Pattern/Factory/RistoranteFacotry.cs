using FirstProject.App.IO;
using FirstProject.App.Pattern.Decorator;

namespace FirstProject.App.Pattern.Factory;
public class RistoranteFacotry
{

   static IPiatto? iPiatto; 

    public static IPiatto Create()
    {
        int scelta = IOutput.Make<int>("Seleziona il piatto da Ordinare" +
        "\n1. Pizza" +
        "\n2. Hamburgher" +
        "\n3. Instalata");

        switch (scelta)
        {
            case 1: iPiatto = new Pizza(); break;
            case 2: iPiatto = new Hamburgher(); break;
            case 3: iPiatto = new Instalata(); break;
            default: iPiatto = new ConcreteComponent(); break;
        }

        return iPiatto;
    }

}