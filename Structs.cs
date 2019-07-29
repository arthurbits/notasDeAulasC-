using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    struct Structs
    {
        /*
            criar um TIPO de var raiz
            não precisa instanciar mas pode
            pode implementar interface
            copia valores de variáveis ao invés de apontar para elas ao receber valor de outra
            após execução é desalocada da memória   
        */

        public double x, y;

        public override string ToString()
        {
            return "("+ x + "," + y + ")";
        }
        
    }
}
