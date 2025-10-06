using FirstProject.App.Helpers.Numeric;
using FirstProject.App.IO;

namespace  FirstProject.App.Terminal;

class RandomTerminal : InputSystem
{
    public static void GuessNumber(int min, int max)
    {
        int response = IOutput.GetInt("Indovina Numero");

        int indovina = InternRandom.Next(min, max);

        while (response != indovina)
        {
            printLine("Errato, non hai indovinato il numero");
        }

        printLine("Numero indivinato! " + response);


    }
    
}