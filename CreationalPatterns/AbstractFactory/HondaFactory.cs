namespace AbstractFactory {
    public class HondaFactory : IVehicleFactory {
        public ICar GetCar() {
            return new HondaCar();
        }

        public IMotorbike GetMotorbike() {
            return new HondaMotorbike();
        }
    }
}