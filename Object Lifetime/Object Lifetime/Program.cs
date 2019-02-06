using System;

namespace Object_Lifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1980;
            myCar.Color = "Silver";

            Car myOtherCar; 
            myOtherCar = myCar;          //linking the second car's properties to the first one's

            Console.WriteLine("{0} {1} {2} {3}",myOtherCar.Make,myOtherCar.Model,myOtherCar.Year,myOtherCar.Color);  //proof of linking

            myOtherCar.Model = "96";    //proof that you can change properties from the second link
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            //you can remove the link by setting the object to null

            //Usage of the overloaded constructor:
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");



            Console.ReadKey();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year {get; set; }
        public string Color { get; set; }

        //CONSTRUCTORS   --These make the default properties :
        public Car()
        {
            Make = "Nissan";
            Model = "Unknown";
            Year = 0;
            Color = "Unset";
        }
         
                         //--Overloading constructors(Note the use of different caps in input parameters)
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }
    }
}
