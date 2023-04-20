using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {   //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            CarLot extraCar = new CarLot();

            //extraCar.Cars.Add();






            //TODO
            // Done 
            //Create a seperate class file called Car 
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // objext initializer syntax 
            Car nextCar = new Car() { Year = 2025, Make = "Lambo", Model = "Aventador", EngineNoise = " Pretty Loud", HonkNoise = " Not Annoying", IsDriveable = true };

            extraCar.Cars.Add(nextCar);
            nextCar.MakeEngineNoise(nextCar.EngineNoise);
            nextCar.MakeHonkNoise(nextCar.HonkNoise);
            Console.WriteLine();
            Console.WriteLine();



            // dot notation          
            Car afterNext = new Car();
            afterNext.Year = 2030;
            afterNext.Make = "Mclaren";
            afterNext.Model = "Mantis";
            afterNext.EngineNoise = "Not Loud";
            afterNext.HonkNoise = " Not Annoying";
            afterNext.IsDriveable = true;

            afterNext.MakeEngineNoise( afterNext.EngineNoise);
            afterNext.MakeHonkNoise(afterNext.HonkNoise);
            Console.WriteLine();
            Console.WriteLine();

            extraCar.Cars.Add(afterNext);

            //custom constructor 
            Car notNext = new Car(2035, "Rolls-Royce", "RR Cullinan", "None", "Truck Pitch", true);

            extraCar.Cars.Add(notNext);

            notNext.MakeEngineNoise(notNext.EngineNoise);
            notNext.MakeHonkNoise(notNext.HonkNoise);
            Console.WriteLine();
            Console.WriteLine();
            
            foreach( var Car in extraCar.Cars)

            {
                Console.WriteLine($"Year :{Car.Year} Make:{Car.Make} Model:{Car.Model}");
            }



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }


        
    }
}
