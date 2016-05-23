namespace DesignPatterns.ChainOfResponsibility
{
    public class Director : DiscountRequestHandler
    {
        public Director(DiscountRequestHandler supervisor)
            : base(supervisor)
        {
        }

        public override DiscountResponse HandleDiscountRequest(DiscountRequest request)
        {
            if (request.DiscountPercentage <= 30)
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
