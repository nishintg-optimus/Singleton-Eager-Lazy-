namespace Singleton
{
    public class Lazy
    {
        
        private Lazy()
        {
            Console.WriteLine("LazyRegistry");
        }

        
        private static volatile Lazy _instance;

       
        public static Lazy GetInstance()
        {
            Console.WriteLine("inside laz");
      
            lock (typeof(Lazy))
            {
                if (_instance == null)
                {
                    _instance = new Lazy();
                }
            }

            return _instance;
        }
    }
}
