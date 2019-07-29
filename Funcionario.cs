using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    class Funcionario
    {
        private string nome;
        private double salario;

        public double mediaSalarial(Funcionario f1, Funcionario f2)
        {
            double media = (f1.salario + f2.salario) / 2;
            return media;
        }

    }
}
