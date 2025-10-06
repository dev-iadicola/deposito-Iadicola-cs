
#nullable disable
namespace FirstProject.App.Entity;

using System.Net.Http.Headers;
using System.Security.Cryptography;
using FirstProject.App.Entity;


class User
{
    private const string password = "password";

    public int loginAttempts = 3;

    public Shopping shopping = new Shopping();
    private Dictionary<string, string> prop;

    public User(string initPassword = password)
    {
        prop = new Dictionary<string, string>();

        prop["password"] = initPassword;
    }

    public string Get(string key)
    {
        return prop.ContainsKey(key) ? prop[key] : null;
    }

    public string Set(string key, string value)
    {
        return prop.ContainsKey(key) ? prop[key] = value : null;
    }

    public bool access(string password)
    {
        return prop["password"] == password;
    }


 public int minusAttempLogin()
    {
        if (loginAttempts <= 0)
        {
            Console.WriteLine("\nNon è possibile effettuare l'accesso, tentativi rimasti 0\n");
        }
        return loginAttempts -= 1;
    }






}