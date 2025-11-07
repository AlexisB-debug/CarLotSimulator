using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Year = 1981,
                Make = "DeLorean",
                Model = "DMC-12",
                IsDriveable = true
            };

            car1.MakeEngineNoise("Vroom");
            car1.MakeHonkNoise("Beep");
            
            Car car2 = new Car();
            car2.Year = 1964;
            car2.Make = "Aston Martin";
            car2.Model = "DB5";
            car2.IsDriveable = true;
            
            car2.MakeEngineNoise("Roar");
            car2.MakeHonkNoise("Honk");
            
            Car car3 = new Car(1927, "Ford", "Model T", false);
            car3.MakeEngineNoise("Sputter-Putt-Sputter");
            //The classic "awooga" horn sound is produced by a Klaxon horn
            car3.MakeHonkNoise("Awooga");
            
            CarLot carLotLoneInstance = new CarLot();
            Console.WriteLine($"Current number of cars kept in the parkinglot: {CarLot.numberOfCars}");
            carLotLoneInstance.ParkingLot.Add(car1);
            carLotLoneInstance.ParkingLot.Add(car2);
            carLotLoneInstance.ParkingLot.Add(car3);
            carLotLoneInstance.InventoryOfCars();
        }
    }
}
