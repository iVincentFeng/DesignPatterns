namespace DesignPatterns.ChainOfResponsibility
{
    public class SalesTaskForce
    {
        public SalesTaskForce()
        {
            this.BuildSalesChain();
        }

        public DiscountResponse ProcessCustomerDiscountRequest(DiscountRequest request)
        {
            return this.salesChain.HandleDiscountRequest(request);
        }

        private void BuildSalesChain()
        {
            President president = new President(null);
            VicePresident vicePresident = new VicePresident(president);
            Director director = new Director(vicePresident);
            Manager manager = new Manager(director);
            Sales sales = new Sales(manager);

            this.salesChain = sales;
        }

        private DiscountRequestHandler salesChain = null;
    }
}
