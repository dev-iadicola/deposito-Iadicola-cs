namespace FirstProject.App.Contracts.Observer;

interface IPObserver<T>
{
    void Update(T newState);
}