namespace AbstractFactory
{
    public class HondaCar : ICar
    {
        public string GetName()
        {
            return "Honda Civic Type-R";
        }

        public int GetNumberOfWheels()
        {
            return 4;
        }
    }
}