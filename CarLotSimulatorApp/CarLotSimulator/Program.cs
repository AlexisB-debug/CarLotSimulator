using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car()
            {
                Year = 1981,
                Make = "DeLorean",
                Model = "DMC-12",
                IsDriveable = true
            };

            car1.MakeEngineNoise("Vroom");
            car1.MakeHonkNoise("Beep");
            
            var car2 = new Car();
            car2.Year = 1964;
            car2.Make = "Aston Martin";
            car2.Model = "DB5";
            car2.IsDriveable = true;
            
            car2.MakeEngineNoise("Roar");
            car2.MakeHonkNoise("Honk");
            
            var car3 = new Car(1927, "Ford", "Model T", false);
            car3.MakeEngineNoise("Sputter-Putt-Sputter");
            //The classic "awooga" horn sound is produced by a Klaxon horn
            car3.MakeHonkNoise("Awooga");
            
            var carLot1 = new CarLot();
            carLot1.ParkingLot.Add(car1);
            carLot1.ParkingLot.Add(car2);
            carLot1.ParkingLot.Add(car3);
            carLot1.InventoryOfCars();
        }
    }
}
