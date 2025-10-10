using FirstProject.App.Helpers;
using FirstProject.App.Helpers.Str;
using FirstProject.App.IO;

namespace FirstProject.App.Entity;

class Student 
{

    public string? name { get; set; }
    public float[] votes { get; set; } = [];
    public int age { get; set; }

    public int year { get; set; }

    public User user;

    public string matricola;

    public Student(User? user = null, float[]? votes = null, int? year = null)
    {
        this.user = user ?? new User("Mario","16");
        this.votes = votes ?? [];
        this.year = year ?? DateTime.Now.Year - Casting.stringToInt(user?.Get("age")) ;
        this.matricola = this.generateMatricola();
    }

    private string generateMatricola()
    {
        string characterSubset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 10;

        return StringManipulation.GenerateRandomString(characterSubset, length);

    }

    public void SetVotes(float[] votes) => this.votes = votes;

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

    public  void Print()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("age: " + year);
        Console.WriteLine("avg: " + this.avg());
        Console.WriteLine("min: " + this.min());
        Console.WriteLine("max: " + this.max());
    }




}