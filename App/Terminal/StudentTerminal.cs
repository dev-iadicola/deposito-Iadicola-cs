namespace FirstProject.App.Terminal;

using FirstProject.App.Entity;
using FirstProject.App.IO;


class StudetTerminal
{
    IOutput? io;
    public Student student;
    public StudetTerminal(Student? student = null)
    {
        this.student = student ?? new Student();

    }

    public void SetVotes()
    {
        Console.Write("Inserici un massimo di 5 voti allo studente: " + this.student.name);
        io = new IOutput(["\nPrimo Voto:", "\nSecondo Voto:", "Terzo Voto:", "Quarto Voto"]);

        student.SetVotes(io.AllFloat());

    }
    
    

   
}