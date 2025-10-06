
#nullable disable
namespace FirstProject.App.Terminal;

using System.Security.Cryptography.X509Certificates;
using FirstProject.App.Entity;
using FirstProject.App.IO;

class BankTerminal
{
    private BankAccount account;
    IOutput io;

    public BankTerminal(BankAccount account)
    {
        this.account = account;

    }

    public void showBalance()
    {
        Console.WriteLine($"\nIl suo saldo attuale è: {this.account.GetBalance()}\n");

    }

    public void DepositOperation()
    {
        io = new IOutput(["\nHai Scelto Deposita Denaro\n"]);
        if (this.account.Deposit(io.GetInt(0)))
            Console.Write($"\n Hai depositato: " + io.GetInt(0) + $"\nSaldo rimanente: {this.account.GetBalance()}\n");
    }

    public void WithdrawOperation()
    {
        io = new IOutput(["\nScegli quantità di denaro da prelevare\n"]);
        if (this.account.Withdraw(io.GetInt(0)))
            Console.WriteLine($"Hai prelevato {io.GetInt(0)}. Saldo attuale: {this.account.GetBalance()}");
    }


}