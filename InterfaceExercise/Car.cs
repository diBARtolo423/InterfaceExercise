using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; }
        public bool IsLowToGround { get; set; }
        public int NumberOfTires { get ; set ; }
        public bool HasGasPedal { get ; set ; }
        public bool HasBreakPedal { get ; set ; }
        public bool HasEngine { get ; set ; }
        public string Logo { get ; set ; }
        public string SalesTeam { get ; set ; }
        public string Name { get ; set ; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Viper's have a trunk: {HasTrunk}");
            Console.WriteLine($"Viper's are low to the ground: {IsLowToGround}");
            Console.WriteLine($"Viper's have this many tires: {NumberOfTires}");
            Console.WriteLine($"Viper's have a gas and break pedal: {HasGasPedal}");
            Console.WriteLine($"Viper's have an engine: {HasEngine}");
            Console.WriteLine($"Viper's logo: {Logo}");
            Console.WriteLine($"Viper's sales team is: {SalesTeam}");
        }
    }
}
