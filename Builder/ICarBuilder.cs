namespace DesignPatterns.Builder
{
    public interface ICarBuilder
    {
        void SetCarColor(string color);

        void SetCarWheels(int wheels);

        Car GetResultCar();
    }
}
