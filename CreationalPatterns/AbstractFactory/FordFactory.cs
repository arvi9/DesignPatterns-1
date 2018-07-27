namespace AbstractFactory {
    public class FordFactory : IVehicleFactory {
        public ICar GetCar() {
            return new FordCar();
        }

        public IMotorbike GetMotorbike() {
            return new FordMotorbike();
        }
    }
}