using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory {
    public class VehicleClient {
        private ICar _car;
        private IMotorbike _motorbike;

        public VehicleClient(IVehicleFactory vehicleFactory) {
            _car = vehicleFactory.GetCar();
            _motorbike = vehicleFactory.GetMotorbike();
        }

        public ICar GetCar() {
            return _car;
        }

        public IMotorbike GetMotorbike() {
            return _motorbike;
        }
    }
}