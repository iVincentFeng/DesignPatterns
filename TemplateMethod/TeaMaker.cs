namespace DesignPatterns.TemplateMethod
{
    public sealed class TeaMaker : BeverageMaker
    {
        protected override void Brew()
        {
        }

        protected override void AddCondiments()
        {
        }
    }
}
