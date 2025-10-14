using FirstProject.App.Core.Singleton;

namespace FirstProject.App.Terminal;


class SingletonTesting
{
    public static void CSystem()
    {
        var moduleA = ConfigSystem.GetInstance();
        var moduleB = ConfigSystem.GetInstance();

        testIstance(moduleA, moduleB);

        moduleA.Set("A", "First test");
        moduleA.Set("B", "The key is B");
        moduleA.Set("B", "Wrong Test"); // update key B
        moduleA.Set("B", "Wrong Test"); // alredy exist in console
        moduleA.Set("C", "The key is C");

        moduleA.PrintMemories(); // prnt all values in memory
    }
    
    private static void testIstance(object obj1, object obj2)
    {
        if (obj1.GetHashCode() ==  obj2.GetHashCode())
        {
            Console.WriteLine("Entrambe le chiamate appartengono alla stessa classe");
            Console.WriteLine($"HashCode obj1: {obj1.GetHashCode()} | HashCode obj2: {obj2.GetHashCode()}");
        } else
        {
            Console.WriteLine("Le chiamate appartengono a chiamate diverse");
            Console.WriteLine($"HashCode obj1: {obj1.GetHashCode()} | HashCode obj2: {obj2.GetHashCode()}");
        }
    }
}