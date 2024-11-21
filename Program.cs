using System.Runtime.ConstrainedExecution;

using Singleton;

public class Mr
{
    static void Main(string[] args)
    {
        //  Singleton s = new Singleton();//not possible
        
        
        Console.WriteLine("started eager");
        EagerRegistry e=EagerRegistry.GetInstance();

        Console.WriteLine("started eager");
        EagerRegistry e2 = EagerRegistry.GetInstance();

        Console.WriteLine("started lazy");
        Lazy l = Lazy.GetInstance();

        Console.WriteLine("started lazy");
        Lazy l2 = Lazy.GetInstance();



        //EagerRegistry er2= EagerRegistry.GetInstance();



    }
}
