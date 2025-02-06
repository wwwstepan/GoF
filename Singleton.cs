namespace GoF;

public sealed class Singleton
{
    private static volatile Singleton? instance;
    private static readonly object syncRoot = new();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance ??= new Singleton();
                }
            }

            return instance;
        }
    }
}