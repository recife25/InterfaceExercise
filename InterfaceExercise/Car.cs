using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car :IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built ford tough";
        public bool HasChangeGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward ...");
        }
        public void Reverse()
        {
            if(HasChangeGears == true) 
            { 
            Console.WriteLine($"{GetType().Name} now reversing  ...");
                HasChangeGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void Park()
        {
            if (HasChangeGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing  ...");
                HasChangeGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangeGears = isChanged;
        }

    }
}
