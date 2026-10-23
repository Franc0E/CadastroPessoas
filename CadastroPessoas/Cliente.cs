using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    internal class Cliente : Pessoa
    {
        public string CodigoCliente;

        public void ExibirDadosCliente() 
        {
            Console.WriteLine("Código do cliente: " + CodigoCliente);
            Apresentar();
        }
    }
}
