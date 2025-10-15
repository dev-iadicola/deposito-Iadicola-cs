namespace FirstProject.App.Contracts.Observer;

interface INotifiable<T>
{

    void Notify(T elem);
    
}