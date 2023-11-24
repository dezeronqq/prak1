using System;

public class Car
    
{
    public string CarName { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string carName, int maxSpeed)
    {
        CarName = carName;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{CarName} - {MaxSpeed}");
    }
}

class Program
{
    public static string McLaren { get; private set; }
    public static string Bugatti { get; private set; }
    public static string Koenigsegg { get; private set; }
    public static string Hennessey { get; private set; }
    public static string Гонка { get; private set; }
    static void Main(string[] args)
    {
        // Реальные гоночные автомобили
        var realRaceCars = new Car[]
        {
         new Car(McLaren, 350),
         new Car(Bugatti, 431),
         new Car(Koenigsegg, 277),
         new Car(Hennessey, 533)
        };

        // Имитация гонок
        for (int i = 0; i < 10; i++)
        {
            Console.
                Clear();
            Console.WriteLine(Гонка + 1);

            Random random = new Random();
            int randomIndex = random.Next(realRaceCars.Length);

            // Выводим информацию об автомобилях
            foreach (var car in realRaceCars)
            {
                car.DisplayInfo();
            }

            Console.WriteLine();

            Thread.Sleep(1000); // Пауза в 1 секунду
        }
    }
}

