using System;

namespace DesignPatterns.Memento
{
    // For internal use only
    internal class InternalState : ICloneable
    {
        internal string StringState
        {
            get;
            set;
        }

        internal int IntegerState
        {
            get;
            set;
        }

        public object Clone()
        {
            InternalState clone = new InternalState()
            {
                StringState = this.StringState,
                IntegerState = this.IntegerState
            };

            return clone;
        }
    }
}
