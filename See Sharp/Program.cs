using See_Sharp_Dynamic_Link_Library;
using See_Sharp_Dynamic_Link_Library_2;
using See_Sharp_Dynamic_Link_Library_3;
public class Program
{
    static public void Main(string[] args)
    {
        AbstractFactoryClass abstractFactory = new AbstractFactoryClass();
        ISingletonFactory singletonFactory = abstractFactory.SingletonFactory();
        ISingleton singletonFactory1 = singletonFactory.CreateSingleton();
        singletonFactory1.Instance();
        Console.WriteLine("Hello, Microsoft!");
    }
}