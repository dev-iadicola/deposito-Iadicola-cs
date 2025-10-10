namespace FirstProject.App.Contracts;

interface IDispositiveE
{
    string Modello { get; set; }

    public void TurnOn();
    public void TurnOff();
    public string ToString();
}