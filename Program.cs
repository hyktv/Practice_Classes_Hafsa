namespace Practice_Classes_Hafsa
{
    //Hafsa Mohamed
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Car Info\n");
            //car instance
            Car car = new Car();
            car.Make = "Kia";
            car.Model = "Optima";
            car.Color = "Black";
            car.Year = 2014;
            car.Mileage = 200000;

            //display the info
            Console.WriteLine($" Make: {car.Make} \n Model: {car.Model} \n Color: {car.Color} \n Year: {car.Year} \n Mileage: {car.Mileage}");

            Console.WriteLine();

            Console.WriteLine(" Bike Info\n");
            //bike instance
            Bike bike = new Bike();
            bike.Brand = "Huffy";
            bike.Color = "Light Blue";
            bike.Type = "Mountain Bike";
            bike.NumOfWheels = 2;

            //display the info
            Console.WriteLine($" Brand: {bike.Brand} \n Color: {bike.Color} \n Type: {bike.Type} \n Number of Wheels: {bike.NumOfWheels}");

            //i cant say that i have a hobby

            //house instance
            //5 bedrooms
            //3 bathrooms
            //Kent

            Console.WriteLine();
            Console.WriteLine(" House Info\n");

            House house = new House();
            house.Bedroom = 5;
            house.Bathroom = 3;
            house.Area = "Kent";

            //display the info 
            Console.WriteLine($" Bedroom: {house.Bedroom} \n Bathroom: {house.Bathroom} \n Area: {house.Area}");

        }//main


    }//class


}//namespace