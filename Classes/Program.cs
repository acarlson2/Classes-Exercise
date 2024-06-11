namespace Classes

{
    public class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Make = "Honda";
            newCar.Model = "Civic";
            newCar.Year = 2020;

            Console.WriteLine($"I own a {newCar.Year} {newCar.Make} {newCar.Model}");
        }
    }
}
