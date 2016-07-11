namespace DesignPatterns.Command
{
    public interface IClipboard
    {
        void SaveText(string text);

        string GetText();
    }
}
