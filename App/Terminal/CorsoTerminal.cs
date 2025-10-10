using FirstProject.App.Entity.Base;
using FirstProject.App.Entity;
using FirstProject.App.IO;
using FirstProject.App.Contracts;

namespace FirstProject.App.Terminal;

class CorsoTerminal
{
    private List<ICurse> corsi = new List<ICurse>();

    public CorsoTerminal()
    {
        Console.WriteLine("=== Gestione Corsi ===");

        while (true)
        {
            Console.WriteLine("\n1) Aggiungi corso in presenza");
            Console.WriteLine("2) Aggiungi corso online");
            Console.WriteLine("0) Esci e mostra tutti i corsi");
            int scelta = IOutput.Make<int>("Scelta: ");

            if (scelta == 0)
                break;

            switch (scelta)
            {
                case 1:
                    this.AggiungiCorsoInPresenza();
                    break;
                case 2:
                    this.AggiungiCorsoOnline();
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }

        Console.WriteLine("\n=== CORSI INSERITI ===");
        foreach (ICurse corso in corsi)
        {
            corso.ErogaCorso();
            corso.StampaDettagli();
            Console.WriteLine("------------------");
        }
    }

    private void AggiungiCorsoInPresenza()
    {
        Console.WriteLine("\n[Nuovo corso in presenza]");
        string titolo = IOutput.Make<string>("Titolo del corso: ");
        int durata = IOutput.Make<int>("Durata in ore: ");
        string aula = IOutput.Make<string>("Aula: ");
        int posti = IOutput.Make<int>("Numero posti: ");

        corsi.Add(new CorsoInPresenza(titolo, durata, aula, posti));
        Console.WriteLine("Corso in presenza aggiunto con successo!");
    }

    private void AggiungiCorsoOnline()
    {
        Console.WriteLine("\n[Nuovo corso online]");
        string titolo = IOutput.Make<string>("Titolo del corso: ");
        int durata = IOutput.Make<int>("Durata in ore: ");
        string piattaforma = IOutput.Make<string>("Piattaforma: ");
        string link = IOutput.Make<string>("Link di accesso: ");

        corsi.Add(new CorsoOnline(titolo, durata, piattaforma, link));
        Console.WriteLine("✅ Corso online aggiunto con successo!");
    }
}
