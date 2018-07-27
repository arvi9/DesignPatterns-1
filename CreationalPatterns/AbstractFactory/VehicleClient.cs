using System;
using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory {
    public class VehicleClient {
        private ICar _car;
        private IMotorbike _motorbike;
        private IVehicleFactory _vehicleFactory;

        public ICar CreateCar(string brand) {
            switch (brand) {
                case "Honda":
                    _vehicleFactory = new HondaFactory();
                    break;
                case "Ford":
                    _vehicleFactory = new FordFactory();
                    break;
                default:
                    throw new Exception("ERROR: This brand does not exist.");
            }

            return _vehicleFactory.GetCar();
        }

        public IMotorbike CreateMotorbike(string brand) {
            switch (brand) {
                case "Honda":
                    _vehicleFactory = new HondaFactory();
                    break;
                case "Ford":
                    _vehicleFactory = new FordFactory();
                    break;
                default:
                    throw new Exception("ERROR: This brand does not exist.");
            }

            return _vehicleFactory.GetMotorbike();
        }
    }
}