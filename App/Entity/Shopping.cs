using FirstProject.App.IO;

namespace FirstProject.App.Entity;

class Shopping
{
    public string[] products = [];

    public Shopping()
    {

    }

    public void Create(string[] products)
    {
        this.products = products;
    }

    public void Print()
    {
        int count = 0;
        foreach (string p in this.products)
        {
            InputSystem.printLine(++count+". " + p);

        }
    }
}