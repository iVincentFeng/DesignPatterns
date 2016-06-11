namespace DesignPatterns.Proxy
{
    public class Proxy : ISubject
    {
        public void Foo()
        {
            // Some extra logic code

            this.subject.Foo();

            // Some extra logic code
        }

        private ISubject subject = new ConcreteSubject();
    }
}
