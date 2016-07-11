namespace DesignPatterns.Command
{
    public class CopyCommand : ICommand
    {
        public CopyCommand(IClipboard clipboard)
        {
            this.clipboard = clipboard;
        }
        
        public void Execute()
        {
            this.clipboard.SaveText(this.Text);
        }

        public string Text
        {
            get;
            set;
        }

        private IClipboard clipboard = null;
    }
}
