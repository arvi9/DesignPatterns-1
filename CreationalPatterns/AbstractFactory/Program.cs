using System;
using AbstractFactory.Factories;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            VehicleClient VehicleClient = new VehicleClient();

            // Create Honda Vehicles
            var HondaCar = VehicleClient.CreateCar("Honda");
            var HondaMotorbike = VehicleClient.CreateMotorbike("Honda");
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", HondaCar.GetName(), HondaCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", HondaMotorbike.GetName(), HondaMotorbike.GetNumberOfWheels()));

            // Create Ford Vehicles
            var FordCar = VehicleClient.CreateCar("Ford");
            var FordMotorbike = VehicleClient.CreateMotorbike("Ford");
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", FordCar.GetName(), FordCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", FordMotorbike.GetName(), FordMotorbike.GetNumberOfWheels()));

            Console.Read();
        }
    }
}