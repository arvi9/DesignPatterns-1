namespace AbstractFactory {
    public class HondaMotorbike : IMotorbike {
        public string GetName() {
            return "Honda Motorbike";
        }

        public int GetNumberOfWheels() {
            return 2;
        }
    }
}