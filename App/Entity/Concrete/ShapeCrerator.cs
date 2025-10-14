using FirstProject.App.Contracts;
using FirstProject.App.Core;
using FirstProject.App.IO;

namespace FirstProject.App.Entity.Concrete;

abstract class ShapeCrerator()
{
    public static IShape? Create(string shape)
    {
        switch (shape.ToLower())
        {
            case "circle": return new Circle();
            case "square": return new Square();
            default: Log.Error($"Shape {shape} not found! Did you means 'circle' or 'square'?"); return null;
        }
    }

}


abstract class Shape : IShape
{
    public virtual void Draw()
    {
        Console.WriteLine("Errore");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Square");

    }

}