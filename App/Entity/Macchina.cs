using System.ComponentModel;
using FirstProject.App.Entity.Base;

namespace FirstProject.App.Entity;

class Macchina : Veicle
{
    private string _motore { get; set; }
    private string _sospensioni { get; set; }
    private float _velocità { get; set; }
    private int _nrModifiche { get; set; }

    public int port = 3;

    public User user;

    public Macchina(User user, string motore, string sospensioni, float velocità, string brand, string model)
        : base(brand, model)
    {
        this.user = user ?? new User("Mario", 10);
        this._motore = motore;
        this._sospensioni = sospensioni;
        this._velocità = velocità;
        this._nrModifiche = 0;
        Print();
    }

    public Macchina(int port, string brand, string model)
        : base(brand, model)
    {
        this.port = port;
    }

    public override string ToString()
    {
        return $"Porte {port} {base.ToString()}";
    }

    public new void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"L'auto ha {port} porte");
    }

    private bool minusCredit()
    {
        if (this != null && this.user != null)
        {
            this.user.credit -= 1;
            return this.user.credit >= 0;
        }
        return false;
    }

    private int GetCredit()
    {
        return this.user.credit;
    }

    public string motore
    {
        get { return _motore; }
        set
        {
            if (this.minusCredit())
            {
                _motore = value; _nrModifiche++; Print();
            }
            else { CreditiInsuff(); }
        }
    }

    private void CreditiInsuff()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Crediti Insufficienti");
        Console.ResetColor();
    }

    public string sospensioni
    {
        get { return _sospensioni; }
        set
        {
            if (this.minusCredit())
            {
                _sospensioni = value;
                _nrModifiche++;
                Print();
            }
            else { CreditiInsuff(); }
        }
    }

    public float velocità
    {
        get { return _velocità; }
        set
        {
            if (value < 600 && this.minusCredit())
            {
                _velocità = value; _nrModifiche++; Print();
            }
            else if (value > 600)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Velocità massima impostabile: 599km/h ");
                Console.ResetColor();
            }
            else
            {
                CreditiInsuff();
            }
        }
    }

    public int nrModifiche
    {
        get { return _nrModifiche; }
        set { _nrModifiche = value; Print(); }
    }

    public void Print()
    {
        System.Console.WriteLine("Motore: " + motore + "\n Sospensioni: "
         + sospensioni + "\n Velocità: " + velocità +
         "\n NrModifiche: " + nrModifiche +
         "\n Credit: " + GetCredit());
    }
}