using System;
using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory {
    public class VehicleFactoryProvider {
        private IVehicleFactory _vehicleFactory;

        public IVehicleFactory GetFactory(string brand) {
            switch (brand) {
                case "Honda":
                    return new HondaFactory();
                case "Ford":
                    return new FordFactory();
                default:
                    throw new Exception("ERROR: This brand does not exist.");
            }
        }
    }
}