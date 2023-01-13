using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfTires { get; set; }
        public bool HasGasPedal { get; set; }
        public bool HasBreakPedal { get; set; }
        public bool HasEngine { get; set; }
        public string Name { get; set; }

    }
}
