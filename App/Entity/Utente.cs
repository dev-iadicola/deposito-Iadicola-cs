#nullable disable
using FirstProject.App.Pattern.Factory;

namespace FirstProject.App.Entity;

class Utente
{
    private static Utente _utente;

    private string _name;

    private Utente(string name)
    {
        _name = name;
    }
   

    public static Utente Instance(string name) => _utente = new Utente(name);

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
        }
    }
    
    public override string ToString()
    {
        return $"Nome Utente: {_name}";
    }


}