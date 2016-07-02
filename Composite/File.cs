namespace DesignPatterns.Composite
{
    public class File : IoNode
    {
        public File(string name) : base(name)
        {
        }

        public override void SomeIoOperation()
        {
            // Some io operation for file
        }
    }
}
