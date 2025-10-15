using FirstProject.App.Entity;

namespace FirstProject.App.Pattern.Factory;

class UserFacotry
{
    public static Utente Create(string name)
    {
        return Utente.Instance(name);
    }
}