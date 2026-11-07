using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public abstract class Pessoa
    {
        private string Nome;
        private int Idade;

        public strign GetNome()
        {
            return Nome;
        }
        public void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
