namespace DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();

        string Text
        {
            get;
            set;
        }
    }
}
