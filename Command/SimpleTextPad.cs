using System.Text;

namespace DesignPatterns.Command
{
    public class SimpleTextPad
    {
        public SimpleTextPad(ICommand copyCommand, ICommand pasteCommand)
        {
            this.copyCommand = copyCommand;
            this.pasteCommand = pasteCommand;
        }

        public void Copy(string text)
        {
            this.copyCommand.Text = text;
            this.copyCommand.Execute();
        }

        public void Paste()
        {
            this.pasteCommand.Execute();
            this.text.Append(this.pasteCommand.Text);
        }

        public string Text
        {
            get
            {
                return this.text.ToString();
            }
        }

        private ICommand copyCommand = null;
        private ICommand pasteCommand = null;
        private StringBuilder text = new StringBuilder();
    }
}
