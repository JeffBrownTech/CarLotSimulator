using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCarLot = new CarLot();

            var car1 = new Car();
            car1.Year = 2022;
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.EngineNoise = "Brrrr";
            car1.HonkNoise = "Beep!";
            myCarLot.Inventory.Add(car1);
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");

            var car2 = new Car()
            {
                Year = 1908,
                Make = "Ford",
                Model = "Model T",
                EngineNoise = "click click click",
                HonkNoise = "Honk!",
                IsDriveable = false
            };
            myCarLot.Inventory.Add(car2);
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");

            var car3 = new Car(2025, "Nissan", "Leaf", "Whirrrr", "Meep!");
            myCarLot.Inventory.Add(car3);
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");

            myCarLot.ListCars();
        }
    }
}
