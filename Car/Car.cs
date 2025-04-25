namespace Car;

public class Car
{
    private string _model;
    private int _year;
    private decimal _price;
    private decimal _speed;

    public Car(string model, int year, decimal price, decimal speed)
    {
        _model = model;
        _year = year;
        _price = price;
        _speed = speed;
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public decimal Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public string GetCarInfo(Car car)
    {
        return $"Model of car: {Model},\nyear of manufacture: {Year},\nit's price: {Price:N0},\nmax.speed: {Speed}";
    }

    public void CalculateDepreciation(int years)
    {
        decimal depreciationRate = 0.1m;
        for (int i = 0; i < years; i++)
        {
            _price -= _price * depreciationRate;
        }
    }
}
