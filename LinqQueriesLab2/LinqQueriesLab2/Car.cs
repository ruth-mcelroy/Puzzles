using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqQueriesLab2
{
    public enum CarMake { Volvo, Mazda, Kia, Skoda, Lada};
    public class Car
    {
        public CarMake Make{get;set;}
        public string Model { get; set; }
        public string Registration { get; set; }
        public int EngineSizeCC { get; set; }

        public Car(CarMake make, string model, string registration,int engineSizeCC)
        {
            Make = make;
            Model = model;
            Registration = registration;
            EngineSizeCC = engineSizeCC;
        }

        public override string ToString()
        {
            return "Make: " + Make.ToString() + " Model: " + Model + " Registration: " + Registration + " EngineSizeCC: " + EngineSizeCC.ToString();
        }
    }

   
}
