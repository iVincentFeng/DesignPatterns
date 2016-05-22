namespace DesignPatterns.Singleton
{
    public sealed class OnDemandLazySingleton
    {
        public static OnDemandLazySingleton GetInstance()
        {
            return NestedClass.Instance;
        }

        private OnDemandLazySingleton()
        {
        }

        private class NestedClass
        {
            public static OnDemandLazySingleton Instance = new OnDemandLazySingleton();
        }
    }
}
