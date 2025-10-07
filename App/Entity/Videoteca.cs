#nullable disable
namespace FirstProject.App.Entity;

using FirstProject.App.Entity;
using FirstProject.App.IO;

class VideoTeca
{
    private List<Film> films;

    private List<Film> toSee;


    public VideoTeca(List<Film> films)
    {
        this.films = films;
        this.toSee = new List<Film>();
    }

    public void PrintAll()
    {
        Console.WriteLine("------LISTA-DEI-NOSTRI-FILM------");
        Console.WriteLine("-------------------");
        foreach (var film in this.films)
        {
            film.Print();
            Console.WriteLine("-------------------");
        }
        Console.WriteLine("-------------------");
        Console.WriteLine("-------FINE-----");
    }

    public void AddFilm(int id)
    {
        if (this.films.Exists(f => f.id == id))
        {
            Film filmToAdd = this.films.Find(f => f.id == id);
            if (!this.toSee.Exists(f => f.id == id))
            {
                this.toSee.Add(filmToAdd);
                Console.WriteLine($"Hai aggiunto {filmToAdd.title} alla lista dei da vedere");
            }
            else
            {
                Console.WriteLine("Film già presente nella lista dei da vedere");
            }
        }
        else
        {
            Console.WriteLine("Film non trovato");
        }
    }

    public void RemoveFilm(int id)
    {
        if (this.toSee.Exists(f => f.id == id))
        {
            Film filmToRemove = this.toSee.Find(f => f.id == id);
            this.toSee.Remove(filmToRemove);
            PrintToSee();
            Console.WriteLine($"Hai rimosso {filmToRemove.title} dalla lista dei da vedere");
        }
        else
        {
            PrintToSee();
            Console.WriteLine("Film non trovato nella lista dei da vedere");
        }
    }

    public void PrintToSee()
    {
        Console.WriteLine("------DA VEDERE------");
        Console.WriteLine("-------------------");
        foreach (var film in this.toSee)
        {
            film.Print();
            Console.WriteLine("-------------------");
        }
        Console.WriteLine("-------------------");
        Console.WriteLine("-------FINE-----");
    }

    public int CountToSee()
    {
        return this.toSee.Count;
    }
}
