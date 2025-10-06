namespace FirstProject.App.Entity;

public class BankAccount
{
    private const int V = 0;
    private int balance;

    public BankAccount(int initialBalance = V)
    {
        balance = initialBalance;
    }

    public int GetBalance()
    {
        return balance;
    }

    public bool Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Non puoi depositare un importo negativo o zero.");
            return false;
        }

        balance += amount;
        return true;
        
    }

    // Prelevare: con validators
    public bool Withdraw(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Importo non valido.");
            return false;
        }

        if (amount > balance)
        {
            Console.WriteLine("Saldo insufficiente.");
            return false;
        }

        balance -= amount;
        return true;
    }
}
