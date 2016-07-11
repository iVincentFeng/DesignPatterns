namespace DesignPatterns.Command
{
    public class SimpleClipboard : IClipboard
    {
        public void SaveText(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return this.text;
        }

        private string text = string.Empty;
    }
}
