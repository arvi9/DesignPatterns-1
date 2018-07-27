namespace AbstractFactory {
    public class FordMotorbike : IMotorbike {
        public string GetName() {
            return "Ford Motorbike";
        }

        public int GetNumberOfWheels() {
            return 2;
        }
    }
}