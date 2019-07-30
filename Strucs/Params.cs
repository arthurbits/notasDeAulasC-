using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    class Params
    {
        public static int Soma( params int[] numbers) {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++) {
                soma += numbers[i];
            }
            return soma;
        }

        public static void TriplicaRef( ref int x) {
            x = x * 3;
        }

        // PARA USAR 
        /*
            int a = 10;
            Params.TriplicaRef(ref a);
            Console.WriteLine(a);  
        */

        public static void TriplicaOut(int origin, out int resultado) {
            resultado = origin * 3;
        }


        // PARA USAR 
        /*
            int a = 10;
            int resultado;
            Params.Triplica( a , out resultado);
            Console.WriteLine(resultado);  
        */

    }
}
