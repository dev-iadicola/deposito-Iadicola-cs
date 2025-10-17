namespace FirstProject.ProgettoFinale;


public interface IPricingStrategy
{
    decimal CalculatePrice(decimal basePrice);
}

public class StandardPricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice) => basePrice;
}

public class PromoPricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice) => basePrice * 0.9m;
}

public class WholesalePricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice) => basePrice * 0.8m;
}

public interface IObserver
{
    void Update(string message);
}

public interface IObservable
{
    void Subscribe(IObserver obs);
    void Unsubscribe(IObserver obs);
    void Notify(string message);
}

public class Order : IObservable
{
    private readonly List<IObserver> _observers = new();
    public IProduct Product { get; set; }
    public IPricingStrategy Strategy { get; set; }

    public Order(IProduct product, IPricingStrategy strategy)
    {
        Product = product;
        Strategy = strategy;
    }

    public void Subscribe(IObserver obs) => _observers.Add(obs);
    public void Unsubscribe(IObserver obs) => _observers.Remove(obs);

    public void Notify(string message)
    {
        foreach (var obs in _observers)
            obs.Update(message);
    }

    public void Checkout()
    {
        decimal finalPrice = Strategy.CalculatePrice(Product.BasePrice);
        Notify($"Ordine completato: {Product.Name} - Prezzo finale: {finalPrice:C}");
    }
}


public class UINotifier : IObserver
{
    public void Update(string message) => Console.WriteLine($"[UI] {message}");
}

public class LogNotifier : IObserver
{
    public void Update(string message) => Console.WriteLine($"[LOG] {message}");
}
