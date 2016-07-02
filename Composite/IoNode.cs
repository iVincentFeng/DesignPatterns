namespace DesignPatterns.Composite
{
    public abstract class IoNode
    {
        public IoNode(string name)
        {
            this.Name = name;
        }

        public abstract void SomeIoOperation();

        public string Name
        {
            get;
            private set;
        }
    }
}
