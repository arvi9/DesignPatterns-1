namespace AbstractFactory {
    public interface IVehicleFactory {
        ICar GetCar();
        IMotorbike GetMotorbike();
    }
}