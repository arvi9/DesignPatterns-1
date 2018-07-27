using AbstractFactory.Models;

namespace AbstractFactory.Factories {
    public class HondaFactory : IVehicleFactory {
        public ICar GetCar() {
            return new HondaCar();
        }

        public IMotorbike GetMotorbike() {
            return new HondaMotorbike();
        }
    }
}