using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise  { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"Listening to a {Year} {Make} {Model}, I hear the sound of its engine, {EngineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"When the horn of a {Year} {Make} {Model} is played, {HonkNoise} is heared");
    }

    public Car()
    {
        // This line of code increments the instances of the Car class which are passed through the default constructor;
        // This line of code fails to increment the instances passed through the custom constructor (parameterized constructor).
        CarLot.numberOfCars = CarLot.numberOfCars + 1;
    }

    public Car(int aYear, string aMake, string aModel, bool aIsDriveable)
    {
        // This line of code increments the instances of the Car class which are passed through the custom constructor;
        // This line of code fails to increment the instances passed through the default constructor.
        CarLot.numberOfCars = CarLot.numberOfCars + 1;
        
        Year = aYear;
        Make = aMake;
        Model = aModel;
        IsDriveable = aIsDriveable;
    }
}