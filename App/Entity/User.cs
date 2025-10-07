
#nullable disable
using System.Security.Cryptography;

namespace FirstProject.App.Entity;

class User
{
    private const string password = "password";

    public int credit { get; set; } = 0;

    public int loginAttempts = 3;

    public Shopping shopping = new Shopping();
    private Dictionary<string, string> prop;

    public User(string initPassword = password)
    {
        prop = new Dictionary<string, string>();

        prop["password"] = initPassword;
    }

    public User(string name, int? credit = 0)
    {
        prop = new Dictionary<string, string>();

        prop["name"] = name ?? "Mario";
        this.credit = credit ?? 0;

    }
    public User(string name, string age, string initPassword = password)
    {
        prop = new Dictionary<string, string>();

        prop["name"] = name ?? "Mario";
        prop["age"] = age ?? "18";

        prop["password"] = initPassword;
    }


    public string Get(string key)
    {
        return prop.ContainsKey(key) ? prop[key] : null;
    }

    public void SetEta(string val)
    {
        prop["eta"] = val;
    }

    public void setName(string val)
    {
        prop["name"] = val;
    }

    //  public static bool isAdult()
    // {
    //     string? ageStr = IOutput.Make("ei maggiorenne?")
    //     int age = Casting.stringToInt(ageStr);

    //     while (age < 0)
    //     {
    //         Console.WriteLine("Inserisci un'età valida");
    //         ageStr = Console.ReadLine();
    //         age = Casting.stringToInt(ageStr);
    //     }
    //     readLine = ageStr;
    //     return Calc.isMajorThan(age, 17);
    // }

    public string Set(string key, string value)
    {
        return prop.ContainsKey(key) ? prop[key] = value : null;
    }

    public bool access(string password)
    {
        return prop["password"] == password;
    }

    public void Print(string value)
    {
        System.Console.WriteLine(prop[value]);
    }

    public void Print()
    {
        foreach (var p in this.prop)
        {
            System.Console.WriteLine($"{p.Key}: {p.Value}");
        }
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