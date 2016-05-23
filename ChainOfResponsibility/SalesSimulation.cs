namespace DesignPatterns.ChainOfResponsibility
{
    public class SalesSimulation
    {
        public void BuildSalesChain()
        {
            President president = new President(null);
            VicePresident vicePresident = new VicePresident(president);
            Director director = new Director(vicePresident);
            Manager manager = new Manager(director);
            Sales sales = new Sales(manager);

            this.salesChain = sales;
        }

        public DiscountResponse ProcessCustomerDiscountRequest(DiscountRequest request)
        {
            return this.salesChain.HandleDiscountRequest(request);
        }

        private DiscountRequestHandler salesChain = null;
    }
}
