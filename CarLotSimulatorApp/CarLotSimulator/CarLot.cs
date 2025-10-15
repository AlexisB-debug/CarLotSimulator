using System;
using System.Collections.Generic;
namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void InventoryOfCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}