namespace Cars_and_Used_Car_Lot;

class Program
{
    

    static void Main(string[] args)
    {
        Console.WriteLine("Hello which vehicle would you like to buy?..");

        







        var newCars = new List<Car>();
        var usedCars = new List<UsedCars>();
        var car = new Car("ford", "Mustang", 2023, 45_000);
        var car2 = new Car("Hyundai", "Elantra", 2022, 32_600);
        var car3 = new Car("Chrysler", "200", 2012, 35_000);
        var usedCar1 = new UsedCars("Cheverlot", "Custom", 2015, 12_000, 150_000);
        var usedCar2 = new UsedCars("Toyota", "Sianna", 2015, 10_000, 80_000);
        var usedCar3 = new UsedCars("Nissan", "Sentra", 2010, 6_000, 90_000);
        newCars.Add(car);
        newCars.Add(car2);
        newCars.Add(car3);
        usedCars.Add(usedCar1);
        usedCars.Add(usedCar2);
        usedCars.Add(usedCar3);
        var userChoice = Console.ReadLine();
        if(int.TryParse(userChoice, out int choice))
        {
           


        }
        
        ListCars(newCars, usedCars);
        
    }

    static void ListCars(List<Car> Cars, List<UsedCars> usedCars)
    {
        for (int x = 0; x < Cars.Count; x += 3)
        {
            var car1 = Cars[x + 0];
            var car2 = Cars[x + 1];
            var car3 = Cars[x + 2];
            Console.WriteLine($"We have \nNew: {car1} \nNew: {car2}\nNew: {car3}");

        }
        for (int i = 0; i < usedCars.Count; i += 3)
        {
            var usedCar = usedCars[i + 0];
            var usedCar2 = usedCars[i + 1];
            var usedCar3 = usedCars[i + 2];
            Console.WriteLine($"Used: {usedCar} \nUsed: {usedCar2} \nUsed: {usedCar3}");
        }

    }

     static void remove(List<Car> removeCar)
    {
        removeCar = new List<Car>();

    }

}


