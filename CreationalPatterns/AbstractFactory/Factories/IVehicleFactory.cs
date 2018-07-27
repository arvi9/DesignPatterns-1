using AbstractFactory.Models;

namespace AbstractFactory.Factories {
    public interface IVehicleFactory {
        ICar GetCar();
        IMotorbike GetMotorbike();
    }
}