namespace DesignPatterns.Visitor
{
    public class ConcreteElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitorElementA(this);
        }
    }
}
