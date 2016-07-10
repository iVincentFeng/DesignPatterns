namespace DesignPatterns.Visitor
{
    public class ConcreteElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitorElementB(this);
        }
    }
}
