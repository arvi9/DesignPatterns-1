using AbstractFactory.Models;

namespace AbstractFactory.Factories {
    public class FordFactory : IVehicleFactory {
        public ICar GetCar() {
            return new FordCar();
        }

        public IMotorbike GetMotorbike() {
            return new FordMotorbike();
        }
    }
}