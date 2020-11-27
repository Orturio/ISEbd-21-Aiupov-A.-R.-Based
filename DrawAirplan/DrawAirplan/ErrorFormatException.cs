using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAirplan
{
    class ErrorFormatException : Exception
    {
        public ErrorFormatException() : base("Неверный формат файла")
        { }
    }
}
