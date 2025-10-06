using FirstProject.App.IO;

namespace FirstProject.App.Entity;

class Student : User
{
    public string name { get; set; }
    public float[] votes { get; set; } = [];
    public int age { get; set; }

    public Student(string? name = null, int? age = null)
    {
        this.name = name ?? "Default Name";
        this.age = age ?? 0;
    }

    public void SetVotes(float[] votes)
    {
        this.votes = votes;
    }

    public float avg()
    {
        return Calc.agv(this.votes);
    }

    public float max()
    {
        return Calc.max(this.votes);
    }
    public float min()
    {
        return Calc.min(this.votes);
    }

    public void Print()
    {

        Console.WriteLine("Name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("avg: " + this.avg());
        Console.WriteLine("min: " + this.min());
        Console.WriteLine("max: " + this.max());
    }


    
    
}