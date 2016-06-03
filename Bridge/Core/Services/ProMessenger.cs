using DesignPatterns.Bridge.Core.Interfaces;

namespace DesignPatterns.Bridge.Core.Services
{
    public class ProMessenger : IMessenger
    {
        public ProMessenger(IMessengerInfrastructure infrastructure)
            : base(infrastructure)
        {
        }

        public override void Login(string userName, string password)
        {
            this.infrastructure.PlaySound();
            this.infrastructure.Connect();
            this.infrastructure.PlaySound();
        }

        public override void SendMessage(string message)
        {
            this.infrastructure.WriteText(message);
            this.infrastructure.PlaySound();
        }

        public override void SendImage(byte[] image)
        {
            this.infrastructure.DrawImage(image);
            this.infrastructure.PlaySound();
        }
    }
}
