namespace DesignPatterns.Visitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitorElementA(ConcreteElementA element)
        {
            // Concrete visitor 2 on element a
        }

        public void VisitorElementB(ConcreteElementB element)
        {
            // Concrete visitor 2 on element b
        }
    }
}
