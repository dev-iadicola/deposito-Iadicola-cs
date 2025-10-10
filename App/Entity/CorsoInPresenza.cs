#nullable disable
using FirstProject.App.Contracts;

namespace FirstProject.App.Entity;

class CorsoInPresenza : ICurse
{
    private string aula;
    private int numeroPosti;

    public string Aula
    {
        get => aula;
        set => aula = !string.IsNullOrWhiteSpace(value) ? value : "Aula non assegnata";
    }

    public int NumeroPosti
    {
        get => numeroPosti;
        set => numeroPosti = value >= 1 ? value : 1;
    }

    public CorsoInPresenza(string titolo, int durataOre, string aula, int numeroPosti)
        : base(titolo, durataOre)
    {
        Aula = aula;
        NumeroPosti = numeroPosti;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Il corso '{Titolo}' si svolge in aula {Aula}.");
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"[IN PRESENZA] Titolo: {Titolo}, Durata: {DurataOre} ore, Aula: {Aula}, Posti: {NumeroPosti}");
    }
}