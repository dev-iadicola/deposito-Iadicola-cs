using FirstProject.App.Contracts;

namespace FirstProject.App.Entity;

class CorsoOnline : ICurse
{
    public string Piattaforma { get; set; }
    public string LinkAccesso { get; set; }

    public CorsoOnline(string titolo, int durataOre, string piattaforma, string linkAccesso)
        : base(titolo, durataOre)
    {
        Piattaforma = piattaforma;
        LinkAccesso = linkAccesso;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Il corso '{Titolo}' è disponibile online su {Piattaforma} ({LinkAccesso}).");
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"[ONLINE] Titolo: {Titolo}, Durata: {DurataOre} ore, Piattaforma: {Piattaforma}");
    }
}
