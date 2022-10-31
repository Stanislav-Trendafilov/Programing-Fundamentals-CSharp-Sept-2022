using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> catalog = new List<Vehicle>();
            while (command != "End")
            {
                string[] cmdArgs = command.Split(" ");
                string vehicleType = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsePower = int.Parse(cmdArgs[3]);

                Vehicle vehicle = new Vehicle(vehicleType, model, color, horsePower);
                catalog.Add(vehicle);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "Close the Catalogue")
            {
                List<Vehicle> searchedVehicles = catalog
                    .Where(x => x.Model == command)
                    .ToList();

                foreach (var vehicle in searchedVehicles)
                {
                    if (vehicle.VehicleType == "car")
                    { Console.WriteLine($"Type: Car"); }
                    else
                    { Console.WriteLine($"Type: Truck"); }

                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
                command = Console.ReadLine();
            }

            List<Vehicle> cars = catalog.Where(x => x.VehicleType == "car").ToList();
            int sum = 0;
            if (cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    sum += item.HorsePower;
                }
                Console.WriteLine($"Cars have average horsepower of: {((double)sum / cars.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            List<Vehicle> trucks = catalog.Where(x => x.VehicleType == "truck").ToList();
            sum = 0;
            if (trucks.Count > 0)
            {
                foreach (var item in trucks)
                {
                    sum += item.HorsePower;
                }
                Console.WriteLine($"Trucks have average horsepower of: {((double)sum / trucks.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, int horsePower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }
}

