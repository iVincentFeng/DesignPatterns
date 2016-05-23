namespace DesignPatterns.ChainOfResponsibility
{
    public class VicePresident : DiscountRequestHandler
    {
        public VicePresident(DiscountRequestHandler supervisor)
            : base(supervisor)
        {
        }

        public override DiscountResponse HandleDiscountRequest(DiscountRequest request)
        {
            if (request.DiscountPercentage <= 40)
            {
                return new DiscountResponse()
                {
                    IsApproved = true
                };
            }

            if (this.Supervisor == null)
            {
                return new DiscountResponse()
                {
                    IsApproved = false
                };
            }

            return this.Supervisor.HandleDiscountRequest(request);
        }
    }
}
