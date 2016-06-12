namespace DesignPatterns.Adapter
{
    public class Adapter : ITarget
    {
        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Foo()
        {
            this.adaptee.Foo1();
            this.adaptee.Foo2();
        }

        private IAdaptee adaptee = null;
    }
}
