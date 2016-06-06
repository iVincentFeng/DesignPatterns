namespace DesignPatterns.Factory.FactoryMethod
{
    public class ConcreteClassFactory : IFactory
    {
        public IInterface CreateInstance()
        {
            return new ConcreteClass();
        }
    }
}
