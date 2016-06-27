namespace DesignPatterns.Memento.Classic
{
    public class Originator
    {
        public Originator()
        {
            this.state = new InternalState()
            {
                StringState = "Initial string state",
                IntegerState = 0
            };
        }

        public void SomeOperationThatChangesState()
        {
            this.state.StringState = "Changed string state";
            this.state.IntegerState = 1;
        }

        public void SetState(Memento state)
        {
            this.state = state.State;
        }

        public Memento GetState()
        {
            return new Memento((InternalState)this.state.Clone());
        }

        private InternalState state = null;
    }
}
