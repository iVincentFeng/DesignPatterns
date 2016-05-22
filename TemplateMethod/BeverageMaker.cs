namespace TemplateMethod
{
    public abstract class BeverageMaker
    {
        public void PrepareBeverage()
        {
            this.BoilWater();
            this.Brew();
            this.PourBeverageIntoCup();
            this.AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater()
        {
        }

        private void PourBeverageIntoCup()
        {
        }
    }
}
