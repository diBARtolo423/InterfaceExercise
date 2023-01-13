using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool HasOpenTrunk { get; set; }
        public bool HasLargeTires { get; set; }
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
            Console.WriteLine($"F150s have an open trunk: {HasOpenTrunk}");
            Console.WriteLine($"F150s have large tires: {HasLargeTires}");
            Console.WriteLine($"F150s have this many tires: {NumberOfTires}");
            Console.WriteLine($"F150s have a gas and break pedal: {HasGasPedal}");
            Console.WriteLine($"F150s have an engine: {HasEngine}");
            Console.WriteLine($"F150s logo: {Logo}");
            Console.WriteLine($"F150s sales team is: {SalesTeam}");
        }
    }
}
