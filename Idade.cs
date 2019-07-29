using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    class Idade
    {
        private string nome;
        private int idade;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return this.idade;
        }

        public string maiorIdade( Idade i1 , Idade i2)
        {
            string msg = "";
            if (i1.idade > i2.idade)
            {
                msg = $" A pessoa mais velha é : {i1.getNome()} ";
            }
            else
            {
                msg = $" A pessoa mais velha é : {i2.getNome()} ";
            }

            return msg;
        }


    }
}
