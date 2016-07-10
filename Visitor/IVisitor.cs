namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void VisitorElementA(ConcreteElementA element);

        void VisitorElementB(ConcreteElementB element);
    }
}
