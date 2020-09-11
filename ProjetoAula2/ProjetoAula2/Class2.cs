using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula2
{
    class Cliente
    {
        public string nome { get; set; }
        public string cpf;
        public string rg;
        public string telefone;
        public int idade { get; set; }

        public Cliente (string nome , int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        

    }
}
