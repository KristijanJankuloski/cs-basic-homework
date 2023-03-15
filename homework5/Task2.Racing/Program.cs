using Task2.Racing.Models;

Driver[] drivers = new Driver[] { new Driver("Luis", 0.82), new Driver("Max", 0.93), new Driver("Zhou", 0.73), new Driver("Perez", 0.84) };
Car[] cars = new Car[] { new Car("Mclaren", 218), new Car("Mercedes", 227), new Car("Redbull", 264), new Car("Ferrari", 243) };

while (true)
{
    Car carNo1 = new Car();
    Driver driverNo1 = new Driver();

    while (true)
    {
        Console.WriteLine("Choose car no.1:");
        foreach (Car car in cars)
        {
            Console.WriteLine($"\t{car.Model}");
        }
        string carInput = Console.ReadLine().ToLower();
        foreach (Car car in cars)
        {
            if (carInput == car.Model.ToLower())
            {
                carNo1 = car;
                break;
            }
        }
        if (carNo1.Model != null)
        {
            break;
        }
        Console.WriteLine("Invalid car. Please try again.");
    }

    while (true)
    {
        Console.WriteLine("Choose driver no.1:");
        foreach (Driver driver in drivers)
        {
            Console.WriteLine($"\t{driver.Name}");
        }
        string driverInput = Console.ReadLine().ToLower();
        foreach (Driver driver in drivers)
        {
            if (driverInput == driver.Name.ToLower())
            {
                driverNo1 = driver;
                break;
            }
        }
        if (driverNo1.Name != null) { break; }
        Console.WriteLine("Invalid diver. Please try again.");
    }

    carNo1.CarDriver = driverNo1;

    Car carNo2 = new Car();
    Driver driverNo2 = new Driver();

    while (true)
    {
        Console.WriteLine("Choose car no.2:");
        foreach (Car car in cars)
        {
            if (car.Model == carNo1.Model)
            {
                continue;
            }
            Console.WriteLine($"\t{car.Model}");
        }
        string carInput = Console.ReadLine().ToLower();
        if (carInput == carNo1.Model.ToLower())
        {
            Console.WriteLine("The car is already taken.");
            continue;
        }
        foreach (Car car in cars)
        {
            if (carInput == car.Model.ToLower())
            {
                carNo2 = car;
                break;
            }
        }
        if (carNo2.Model != null)
        {
            break;
        }
        Console.WriteLine("Invalid car. Please try again.");
    }

    while (true)
    {
        Console.WriteLine("Choose driver no.2:");
        foreach (Driver driver in drivers)
        {
            if (driver.Name == driverNo1.Name)
            {
                continue;
            }
            Console.WriteLine($"\t{driver.Name}");
        }
        string driverInput = Console.ReadLine().ToLower();
        if (driverInput == driverNo1.Name.ToLower())
        {
            Console.WriteLine("The driver is already in the race");
            continue;
        }
        foreach (Driver driver in drivers)
        {
            if (driverInput == driver.Name.ToLower())
            {
                driverNo2 = driver;
                break;
            }
        }
        if (driverNo2.Name != null) { break; }
        Console.WriteLine("Invalid diver. Please try again.");
    }

    carNo2.CarDriver = driverNo2;

    RaceCars(carNo1, carNo2);


    Console.WriteLine("Would you like to race again? (Y/N)");
    string userOption = Console.ReadLine();
    if (userOption == "y" || userOption == "Y")
    {
        Console.WriteLine("Starting another race!\n=======================");
        continue;
    }
    break;
}

void RaceCars(Car car1, Car car2)
{
    if (car1.CalculateSpeed() > car2.CalculateSpeed())
    {
        Console.WriteLine(String.Format("{0} Wins! With {1} and a speed of {2:.##}Km/h", car1.CarDriver.Name, car1.Model, car1.CalculateSpeed()));
        return;
    }
    if (car2.CalculateSpeed() > car1.CalculateSpeed())
    {
        Console.WriteLine(String.Format("{0} Wins! With {1} and a speed of {2:.##}Km/h", car2.CarDriver.Name, car2.Model, car2.CalculateSpeed()));
        return;
    }
    Console.WriteLine("Drivers are evenly matched");
}