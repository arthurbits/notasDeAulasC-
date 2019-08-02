using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos.Polimorfismo
{
    class Animal 
    {
        public string Nome { get; set; }

        public virtual string som() {
            return "som do animal";
        }

        // Uso : 
        /*
            Animal dog = new Cachorro() { Nome = "Doginho" };
            Console.WriteLine(dog.som());

            Animal cat = new Gato() { Nome = "Gatinho" };
            Console.WriteLine(cat.som());  
        */
    }
}
