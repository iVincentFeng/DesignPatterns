namespace DesignPatterns.Visitor
{
    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitorElementA(ConcreteElementA element)
        {
            // Concrete visitor 1 on element a
        }

        public void VisitorElementB(ConcreteElementB element)
        {
            // Concrete visitor 1 on element b
        }
    }
}
