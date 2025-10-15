namespace FirstProject.App.Contracts.Observer;

interface ISubject
{
    void Attach(IObserver iobs);
    void Detach(IObserver iobs);
    void Notify();
}