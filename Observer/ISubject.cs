using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public abstract class ISubject
    {
        private List<IUpdateProgress> observers = new List<IUpdateProgress>();

        public void RegisterProgressObserver(IUpdateProgress observer)
        {
            this.observers.Add(observer);
        }

        public void UnregisterProgressObserver(IUpdateProgress observer)
        {
            this.observers.Remove(observer);
        }

        protected void NotifyProgressObservers(float progress)
        {
            foreach (IUpdateProgress observer in this.observers)
            {
                observer.UpdateProgress(progress);
            }
        }
    }
}
