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
            return nome;
        }
        public strign SetNome(string novoNome)
        {
            nome = novoNome;
        }
        public strign GetIdade()
        {
            return idade;
        }
        public strign SetIdade(int novaIdade)
        {
            Idade = novaIdade;
        }
        public void Apresentar()
        {
            Console.WriteLine("Nome: " + GetNome);
            Console.WriteLine("Idade: " + GetIdade);
        }
        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
