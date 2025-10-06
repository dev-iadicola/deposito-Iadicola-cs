
namespace FirstProject.App.Terminal;
using FirstProject.App.Entity;
using FirstProject.App.IO;


class UserTerminal : InputSystem
{
    public User user;
    IOutput? io;



    public bool passwordCorrect = false;

    public UserTerminal(User? user = null)
    {
        this.user = user ?? new User();
    }

    

    public void sendRequestLogin()
    {
        io = new IOutput(["Inserisci la password\n"]);

        if (user.access(io.Get(0)) && user.loginAttempts > 0)
        {
            Console.WriteLine("Accesso eseguito!\n");
            passwordCorrect = true;
        }
        else
        {
            user.minusAttempLogin();
            Console.WriteLine("Accesso negato, credenziali errate. Tentativi rimasti: " + user.loginAttempts);
        }
    }

    public void Calculator()
    {
        
    }


    public void Shopping()
    {
        printLine("Inserisci lista spesa di 5 prodotti: ");
        string baseMesssage = "Prodotto N°";
        string[] messages = new string[5];
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i] = $"{baseMesssage + (i + 1)}";
        }
        io = new IOutput(messages);

        this.user.shopping.Create(io.AllString());
        this.user.shopping.Print();
    }

    

}