namespace DesignPatterns.ChainOfResponsibility
{
    public class Manager : DiscountRequestHandler
    {
        public Manager(DiscountRequestHandler supervisor)
            : base(supervisor)
        {
        }

        public override DiscountResponse HandleDiscountRequest(DiscountRequest request)
        {
            if (request.DiscountPercentage <= 20)
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
