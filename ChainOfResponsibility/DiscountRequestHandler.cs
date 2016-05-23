namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class DiscountRequestHandler
    {
        public DiscountRequestHandler(DiscountRequestHandler supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract DiscountResponse HandleDiscountRequest(DiscountRequest request);

        protected DiscountRequestHandler Supervisor
        {
            get;
            private set;
        }
    }
}
