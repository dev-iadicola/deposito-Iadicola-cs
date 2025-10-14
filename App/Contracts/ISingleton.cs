namespace FirstProject.App.Contracts;

interface ISingleton
{
    private static object _istance = new object();
    public static object GetIstance()
    {
        throw new System.NotImplementedException();
    }
}