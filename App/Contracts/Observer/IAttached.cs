namespace FirstProject.App.Contracts.Observer;

interface IAttached<T>
{
    void Attached(T observer);
}