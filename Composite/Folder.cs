using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Folder : IoNode
    {
        public Folder(string name) : base(name)
        {
        }

        public override void SomeIoOperation()
        {
            // Some io operation for folder

            // Some io operation for children
            foreach (IoNode child in this.children)
            {
                child.SomeIoOperation();
            }
        }

        public void Add(IoNode child)
        {
            this.children.Add(child);
        }

        public void Remove(IoNode child)
        {
            this.children.Remove(child);
        }

        private IList<IoNode> children = new List<IoNode>();
    }
}
