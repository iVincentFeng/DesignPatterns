namespace DesignPatterns.Builder
{
    public class CarBuilderDirector
    {
        public Car BuildCar(ICarBuilder carBuilder)
        {
            carBuilder.SetCarColor("Red");
            carBuilder.SetCarWheels(4);

            return carBuilder.GetResultCar();
        }
    }
}
