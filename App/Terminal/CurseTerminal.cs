using FirstProject.App.Entity.Base;
using FirstProject.App.IO;

namespace FirstProject.App.Terminal;

class CurseTerminal
{

    public CurseTerminal()
    {
        bool exit = true;
        do
        {
            Console.WriteLine("0.esci.");
            Console.WriteLine("1. Aggiungi un corso di muica.");
            Console.WriteLine("2. Aggiungi un corso di pittura.");
            Console.WriteLine("3. Aggiungi un corso di danza.");
            Console.WriteLine("4. Aggiungi un corso di danza.");
            Console.WriteLine("5. Aggiungi uno studente e seleziona corso.");
            Console.WriteLine("6. Visualizza corsi.");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0: exit = false; break;
                case 1:
                   
                    break;
                case 2:
                   
                    break;

                case 3: ; break;
            }
        } while (exit);
    }

}

class CDanza : Curse
{
    private string strumento;
    public CDanza(string name, int ore, string docente, string strumento)
    : base(name, ore, docente)
    {
        this.strumento = strumento;
    }

    public string MSpecial()
    {
        return "Si utilizza lo strimento: " + this.strumento;
    }

    public override string ToString()
    {
            return base.ToString() + this.MSpecial();
    }

}

class CPittura : Curse
{
    private string strumento;
    public CPittura(string name, int ore, string docente, string strumento)
    : base(name, ore, docente)
    {
        this.strumento = strumento;
    }

    public string MSpecial()
    {
        return "Si lavora su tela con la tecnica: " + this.strumento;
    }

    public override string ToString()
    {
        return base.ToString() + this.MSpecial();
    }

}


class CMusica : Curse
{
    private string strumento;
    public CMusica(string name, int ore, string docente, string strumento)
    : base(name, ore, docente)
    {
        this.strumento = strumento;
    }

    public string MSpecial()
    {
        return "Esecuzione Correografica nello stile : " + this.strumento;
    }

    public override string ToString()
    {
        return base.ToString() + this.MSpecial();
    }
    
}