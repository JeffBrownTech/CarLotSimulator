using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public static int numberOfCars;
    public List<Car> Inventory { get; set; } = new List<Car>();

    public void ListCars()
    {
        Console.WriteLine("Year\tMake\tModel");
        foreach (var car in Inventory)
        {
            Console.WriteLine($"{car.Year}\t{car.Make}\t{car.Model}");
        }
    }
}
