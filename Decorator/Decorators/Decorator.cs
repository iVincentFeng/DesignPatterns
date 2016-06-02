namespace DesignPatterns.Decorator.Decorators
{
    public abstract class Decorator : Stream
    {
        public Decorator(Stream stream)
        {
            this.stream = stream;
        }

        protected Stream stream;
    }
}
