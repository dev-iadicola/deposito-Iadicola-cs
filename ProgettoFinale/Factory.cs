namespace FirstProject.ProgettoFinale;
public interface IProduct
{
    string Name { get; }
    decimal BasePrice { get; }
}

public class Factory
{
    public static IProduct CreateProduct(string code)
    {
        return code.ToUpper() switch
        {
            "TSHIRT" => new TShirt(),
            "MUG" => new Mug(),
            "SKIN" => new Skin(),
            _ => throw new ArgumentException("Codice prodotto non valido")
        };
    }
}

public class TShirt : IProduct
{
    public string Name => "T-Shirt";
    public decimal BasePrice => 15m;
}

public class Mug : IProduct
{
    public string Name => "Mug";
    public decimal BasePrice => 10m;
}

public class Skin : IProduct
{
    public string Name => "Skin";
    public decimal BasePrice => 5m;
}
