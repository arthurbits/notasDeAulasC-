using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    class Idade
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string maiorIdade( Idade i1 , Idade i2)
        {
            string msg = "A pessoa mais velha é : ";
            msg += (i1.Age > i2.Age) ? i1.Name : i2.Name;
            return msg;
        }


    }
}
