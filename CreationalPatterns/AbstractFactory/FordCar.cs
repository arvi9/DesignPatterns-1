namespace AbstractFactory {
    public class FordCar : ICar {
        public string GetName() {
            return "Ford Mustang GT";
        }

        public int GetNumberOfWheels() {
            return 4;
        }
    }
}