namespace FirstProject.App.Entity;

class Education
{
    public Education(string materia)
    {
        Materia = materia;
    }

    public string Materia { get; }
}