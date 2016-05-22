namespace DesignPatterns.Singleton
{
    public sealed class ThreadUnsafeLazySingleton
    {
        public static ThreadUnsafeLazySingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new ThreadUnsafeLazySingleton();
            }

            return instance;
        }

        private ThreadUnsafeLazySingleton()
        {
        }

        private static ThreadUnsafeLazySingleton instance = null;
    }
}
