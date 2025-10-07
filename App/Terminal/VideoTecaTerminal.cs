namespace FirstProject.App.Terminal;

using FirstProject.App.Entity;
using FirstProject.App.IO;

class VideoTecaTerminal
{

    private VideoTeca videoteca;

    public VideoTecaTerminal()
    {
        // creazione
        List<Film> films = new List<Film> {
            new Film("Inception", "Christopher Nolan", 2010, "Sci-Fi"),
            new Film("The Godfather", "Francis Ford Coppola", 1972, "Crime"),
            new Film("Pulp Fiction", "Quentin Tarantino", 1994, "Crime"),
            new Film("The Dark Knight", "Christopher Nolan", 2008, "Action"),
            new Film("Forrest Gump", "Robert Zemeckis", 1994, "Drama")
        };

        // popolazione
        this.videoteca = new VideoTeca(films);
        bool exit = false;

        // inizio programma
        System.Console.WriteLine("Benvenuto nella Videoteca!");
        System.Console.WriteLine("I seguenti tasti ti permetteranno di scegliere le opzioni disponibili");


        do
        {
            System.Console.WriteLine("1. Visualizza tutti i film.\n" +
      "2. Scegli il film\n" +
      "3. Rimuovi il film\n" +
      "4. Visualizza i film scelti\n" +
      "0. Esci"
      );
            int choice = Convert.ToInt32(Console.ReadLine());
            int id;
            switch (choice)
            {
                case 1:
                    this.videoteca.PrintAll();
                    break;
                case 2:
                    this.videoteca.PrintAll();
                    id = IOutput.Make<int>("Inserisci l'id del film da aggiungere alla lista dei da vedere: ");
                    this.videoteca.AddFilm(id);
                    break;
                case 3:
                    this.videoteca.PrintAll();
                    id = IOutput.Make<int>("Inserisci l'id del film da RIMUOVERE alla lista dei da vedere: ");
                    this.videoteca.RemoveFilm(id);
                    break;
                case 4:
                    this.videoteca.PrintToSee();
                    break;
                case 0:
                    Console.WriteLine("Uscita dalla Videoteca. Arrivederci!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        } while (!exit && films.Count >= 3);

        if (exit == true && films.Count < 3)
        {
            System.Console.WriteLine("devi scegliere almeno 3 film per noleggiarli\nArrivederci!");
        }
        else
        {
            System.Console.WriteLine("Hia scelto " + this.videoteca.CountToSee() + "Films");
            this.videoteca.PrintToSee();
            System.Console.WriteLine("Buona Visione!");
        }



    }

}
