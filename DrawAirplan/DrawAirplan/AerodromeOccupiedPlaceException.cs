using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    class AerodromeOccupiedPlaceException : Exception
    {
        public AerodromeOccupiedPlaceException() : base("Не удалось посадить")
        { }
    }
}
