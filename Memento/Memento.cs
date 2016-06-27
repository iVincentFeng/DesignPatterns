namespace DesignPatterns.Memento
{
    // Client code only knows about this class, but not its inner details.
    public class Memento
    {
        internal Memento(InternalState state)
        {
            this.State = state;
        }

        internal InternalState State
        {
            get;
            set;
        }
    }
}
