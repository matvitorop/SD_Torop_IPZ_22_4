namespace Singleton
{
    public sealed class Authenticator
    {
        private static Authenticator? _authenticator;

        private static object _refObject = new object();


        private Authenticator()
        {
            Console.WriteLine("Making authentification");
        }

        public static Authenticator GetInstance() 
        {
            if (Authenticator._authenticator == null)
            {
                lock (Authenticator._refObject)
                {
                    if (Authenticator._authenticator == null)
                    {
                        Authenticator._authenticator = new Authenticator();
                    }
                }
            }
            return Authenticator._authenticator;
        }
    }
}
