using System;
using System.Collections.Generic;
using System.Globalization;

namespace Orientado_a_Objetos
{
    class Lista
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary( double percentage) {
            Salary += Salary * percentage;
        }

        public override string ToString()
        {
            return "ID : " + Id +
                   ", Name : " + Name +
                   ", Salary : " + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
