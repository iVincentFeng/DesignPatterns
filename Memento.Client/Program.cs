using DesignPatterns.Memento.Classic;

namespace DesignPatterns.Memento.Client
{
    public class Program
    {
        static void Main()
        {
            Originator orig = new Originator();

            // Save the state
            Memento.Classic.Memento savedState = orig.GetState();

            orig.SomeOperationThatChangesState();

            // Restore the state
            orig.SetState(savedState);
        }
    }
}
