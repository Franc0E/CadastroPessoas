using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    internal class Funcionario : Pessoa
    {
        public decimal Salario;

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }
        public void ExibirDadosFuncionario() 
        {
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bônus: " + CalcularBonus());
            Apresentar();
        }
    }
}
