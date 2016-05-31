namespace DesignPatterns.Strategy
{
    public class SalesOrder
    {
        public SalesOrder(ICalculateTax taxCalculator)
        {
            this.taxCalculator = taxCalculator;
        }

        public double CalculateTax()
        {
            Context context = new Context();

            return this.taxCalculator.CalculateTax(context);
        }

        private ICalculateTax taxCalculator = null;
    }
}
