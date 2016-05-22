namespace DesignPatterns.Strategy
{
    public class Duck
    {
        public Duck(IQuack quackHandler, IFly flyHandler)
        {
            this.quackHandler = quackHandler;
            this.flyHandler = flyHandler;
        }

        public void Quack()
        {
            this.quackHandler.Quack();
        }

        public void Fly()
        {
            this.flyHandler.Fly();
        }

        private IQuack quackHandler = null;
        private IFly flyHandler = null;
    }
}
