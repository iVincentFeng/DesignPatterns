namespace DesignPatterns.Bridge.Core.Interfaces
{
    public interface IMessengerInfrastructure
    {
        void PlaySound();

        void DrawImage(byte[] image);

        void WriteText(string text);

        void Connect();
    }
}
