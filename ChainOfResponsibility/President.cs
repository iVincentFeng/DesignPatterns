namespace DesignPatterns.ChainOfResponsibility
{
    public class President : DiscountRequestHandler
    {
        public President(DiscountRequestHandler supervisor)
            : base(supervisor)
        {
        }

        public override DiscountResponse HandleDiscountRequest(DiscountRequest request)
        {
            if (request.DiscountPercentage <= 50)
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
