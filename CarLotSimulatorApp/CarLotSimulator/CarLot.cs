using System;
using System.Collections.Generic;
namespace CarLotSimulator;

public class CarLot
{
    public static int numberOfCars;
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void InventoryOfCars()
    {
        foreach (Car vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}