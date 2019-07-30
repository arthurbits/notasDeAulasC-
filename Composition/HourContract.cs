using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos.Composition
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValeuPerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue() { return Hours * ValeuPerHour; }
    }
}
