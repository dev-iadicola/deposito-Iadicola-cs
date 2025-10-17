
namespace FirstProject.App.Pattern.Decorator;
#region Interfaccia dei piatti Pizza, Hamburgher etc etc

public interface IPiatto
{
    string Descrizione();

    string Prepara();
}

#endregion

#region  I Piatti
public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return "Pizza ";
    }

    public string Prepara()
    {
        return "Preparazione pizza con impasto, salsa e";
    }
}

public class Hamburgher : IPiatto
{
    public string Descrizione()
    {
        return "Hamburgher ";
    }

    public string Prepara()
    {
        return "Preparazione Humburgher di bovino, ";
    }
}

public class Instalata : IPiatto
{
    public string Descrizione()
    {
        return "Insalata ";
    }

    public string Prepara()
    {
        return "Preparazione instalata fresca con verdure e condimenti ";
    }
}
#endregion

// 2. ConcreteComponent: oggetto base senza decorazioni
public class ConcreteComponent : IPiatto
{
    public string Descrizione()
    {
        return "Piatto: ";
    }

    public string Prepara()
    {
        return "In Preparazione: ";
    }

    
}

#region Interfaccia Decorator
public abstract class Decorator : IPiatto
{
    // Riferimento al componente "decorato"
    protected IPiatto _component;

    // Costruttore: richiede un componente da decorare
    protected Decorator(IPiatto component)
    {
        _component = component;
    }

    // Delegazione dell'operazione al componente interno
    public virtual string Descrizione()
    {
        return _component.Descrizione();
    }

    public virtual string Prepara()
    {
        return _component.Prepara();
    }


}
#endregion

#region  Con Inserimento Decorazioni del piatto
public class ConSalsa : Decorator
{
    public ConSalsa(IPiatto component)
        : base(component) { }

    public override string Descrizione()
    {
        return base.Descrizione() + "+ Salsa";  // chiama Operation() sul componente interno
    }

    public override string Prepara()
    {
        return base.Prepara() + ", con salsa";
    }


}

public class ConBacon : Decorator
{
    public ConBacon(IPiatto component)
        : base(component) { }

    public override string Descrizione()
    {
        return base.Descrizione() + "+ Bacon";
    }

    public override string Prepara()
    {
        return base.Prepara() + ", con bacon";
    }
}

public class ConnFormaggio : Decorator
{
    public ConnFormaggio(IPiatto component)
        : base(component) { }

    public override string Descrizione()
    {
        return base.Descrizione() + "+ Formaggio";
    }

    public override string Prepara()
    {
        return base.Prepara() + ", con Formaggio";
    }
}

#endregion