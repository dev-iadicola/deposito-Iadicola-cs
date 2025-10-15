namespace FirstProject.App.Contracts.Observer;

 interface IPSubject<T>
    {
        void Attach(IPObserver<T> observer);
        void Detach(IPObserver<T> observer);
        void Notify();
    }