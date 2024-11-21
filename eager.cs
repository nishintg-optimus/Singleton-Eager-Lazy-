using System;

namespace Singleton
{
    public class EagerRegistry
    {
        
        private EagerRegistry()
        {
            Console.WriteLine("EagerRegistry");
        }

        
        private static readonly EagerRegistry INSTANCE = new EagerRegistry();

   
        public static EagerRegistry GetInstance()
        {
            Console.WriteLine("inside ee");
            return INSTANCE;
        }
    }
}
