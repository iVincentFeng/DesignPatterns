namespace DesignPatterns.Command
{
    public class PasteCommand : ICommand
    {
        public PasteCommand(IClipboard clipboard)
        {
            this.clipboard = clipboard;
        }

        public void Execute()
        {
            this.Text = this.clipboard.GetText();
        }

        public string Text
        {
            get;
            set;
        }

        private IClipboard clipboard = null;
    }
}
