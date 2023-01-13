using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public bool HasEnclosedTrunk { get; set; }
        public bool IsOffRoad { get; set; }
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
            Console.WriteLine($"Wranglers have an eclosed trunk: {HasEnclosedTrunk}");
            Console.WriteLine($"Wranglers are made to go off-road: {IsOffRoad}");
            Console.WriteLine($"Wranglers have this many tires: {NumberOfTires}");
            Console.WriteLine($"Wranglers have a gas and break pedal: {HasGasPedal}");
            Console.WriteLine($"Wranglers have an engine: {HasEngine}");
            Console.WriteLine($"Wranglers logo: {Logo}");
            Console.WriteLine($"Wranglers sales team is: {SalesTeam}");
        }
    }
}
