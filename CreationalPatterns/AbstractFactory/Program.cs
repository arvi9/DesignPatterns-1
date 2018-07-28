using System;
using AbstractFactory.Factories;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            VehicleFactoryProvider FactoryProvider = new VehicleFactoryProvider();
            var HondaFactory = FactoryProvider.GetFactory("Honda");
            var FordFactory = FactoryProvider.GetFactory("Ford");

            // Create Honda Vehicles
            var HondaCar = HondaFactory.GetCar();
            var HondaMotorbike = HondaFactory.GetMotorbike();
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", HondaCar.GetName(), HondaCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", HondaMotorbike.GetName(), HondaMotorbike.GetNumberOfWheels()));

            // Create Ford Vehicles
            var FordCar = FordFactory.GetCar();
            var FordMotorbike = FordFactory.GetMotorbike();
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", FordCar.GetName(), FordCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("You created a new {0} with {1} wheels.", FordMotorbike.GetName(), FordMotorbike.GetNumberOfWheels()));

            Console.Read();
        }
    }
}