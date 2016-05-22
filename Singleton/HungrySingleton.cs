namespace DesignPatterns.Singleton
{
    public sealed class HungrySingleton
    {
        public static HungrySingleton GetInstance()
        {
            return instance;
        }

        private HungrySingleton()
        {
        }

        private static HungrySingleton instance = new HungrySingleton();
    }
}
