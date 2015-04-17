using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqQueriesLab2
{
    public class Test
    {
        static void Main()
        {
            List<Car> fleet = new List<Car>();

            fleet.Add( new Car(CarMake.Mazda, "M403", "93-D-342", 1600));
            fleet.Add( new Car(CarMake.Lada, "L9877", "05-D-342", 2000));
            fleet.Add( new Car(CarMake.Skoda, "Sewkjf", "01-D-342", 1600));
            fleet.Add( new Car(CarMake.Kia, "K221", "131-D-342", 1500));
            fleet.Add( new Car(CarMake.Mazda, "M0896", "142-D-342", 1600));
            fleet.Add(new Car(CarMake.Lada, "L233", "09-D-342", 3000));
            fleet.Add( new Car(CarMake.Mazda, "M754", "132-D-342", 1700));

           
            
            var filteredFleet = fleet.OrderBy(car => car.Registration);

            foreach (var carReg in filteredFleet)
            {
                Console.WriteLine(carReg);
            }
            Console.WriteLine();
            var filteredFleet2 = fleet.Where(car=> car.Make == CarMake.Mazda);

            foreach (var car in filteredFleet2)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            var filteredFleet3 = fleet.OrderByDescending(car => car.EngineSizeCC);

            foreach (var car in filteredFleet3)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            var filteredFleet4 = fleet.OrderByDescending(car => car.EngineSizeCC);

            foreach (var car in filteredFleet3)
            {
                Console.WriteLine(car);
            }


        }
    }
}
