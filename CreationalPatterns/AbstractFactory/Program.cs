using System;
using AbstractFactory.Factories;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            IVehicleFactory HondaFactory = new HondaFactory();
            VehicleClient HondaClient = new VehicleClient(HondaFactory);
            var HondaCar = HondaClient.GetCar();
            var HondaMotorbike = HondaClient.GetMotorbike();

            Console.WriteLine(String.Format("{0} has {1} wheels.", HondaCar.GetName(), HondaCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("{0} has {1} wheels.", HondaMotorbike.GetName(), HondaMotorbike.GetNumberOfWheels()));

            IVehicleFactory FordFactory = new FordFactory();
            VehicleClient FordClient = new VehicleClient(FordFactory);
            var FordCar = FordFactory.GetCar();
            var FordMotorbike = FordFactory.GetMotorbike();

            Console.WriteLine(String.Format("{0} has {1} wheels.", FordCar.GetName(), FordCar.GetNumberOfWheels()));
            Console.WriteLine(String.Format("{0} has {1} wheels.", FordMotorbike.GetName(), FordMotorbike.GetNumberOfWheels()));

            Console.Read();
        }
    }
}