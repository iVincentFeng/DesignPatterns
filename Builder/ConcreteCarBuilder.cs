namespace DesignPatterns.Builder
{
    public class ConcreteCarBuilder : ICarBuilder
    {
        public void SetCarColor(string color)
        {
            this.car.Color = color;
        }

        public void SetCarWheels(int wheels)
        {
            this.car.Wheels = wheels;
        }

        public Car GetResultCar()
        {
            return this.car;
        }

        private Car car = new Car();
    }
}
