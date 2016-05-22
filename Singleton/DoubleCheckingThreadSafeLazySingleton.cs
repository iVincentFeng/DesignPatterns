namespace DesignPatterns.Singleton
{
    public sealed class DoubleCheckingThreadSafeLazySingleton
    {
        public static DoubleCheckingThreadSafeLazySingleton GetInstance()
        {
            if (instance == null)
            {
                lock (mutex)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckingThreadSafeLazySingleton();
                    }
                }
            }

            return instance;
        }

        private DoubleCheckingThreadSafeLazySingleton()
        {
        }

        private static DoubleCheckingThreadSafeLazySingleton instance = null;
        private static object mutex = new object();
    }
}
