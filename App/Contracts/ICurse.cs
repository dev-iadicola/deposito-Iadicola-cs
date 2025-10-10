namespace FirstProject.App.Contracts;

public abstract class ICurse
{
    private string titolo = " ";
    private int durataOre;

    public string Titolo
    {
        get => titolo;
        set => titolo = !string.IsNullOrWhiteSpace(value) ? value : "Senza titolo";
    }

    public int DurataOre
    {
        get => durataOre;
        set => durataOre = value > 0 ? value : 1;
    }

    public ICurse(string titolo, int durataOre)
    {
        Titolo = titolo;
        DurataOre = durataOre;
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}