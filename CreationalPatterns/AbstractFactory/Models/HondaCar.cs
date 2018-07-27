namespace AbstractFactory.Models
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