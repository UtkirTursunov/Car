namespace Car;

internal class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Tracker", 2025, 282000000, 220);

        Console.WriteLine(myCar.GetCarInfo(myCar));
        Console.WriteLine();
        myCar.CalculateDepreciation(1);
        Console.WriteLine($"Car's price after some years: {myCar.Price:N0}");
    }
}
