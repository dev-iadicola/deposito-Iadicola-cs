namespace FirstProject.App.Contracts.Observer; 

interface IDetached<T>
{
    void Detach(T observer);
}