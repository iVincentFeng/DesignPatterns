namespace DesignPatterns.Bridge
{
    public interface IMessenger
    {
        void Login(string userName, string password);

        void SendMessage(string message);

        void SendImage(byte[] image);
    }
}
