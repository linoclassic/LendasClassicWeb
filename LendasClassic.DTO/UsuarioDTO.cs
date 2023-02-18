using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendasClassic.DTO
{
    public class UsuarioDTO
    {

        // Obs 1: O banco de dados esta com o nome final "Cliente", mas seria "Usuario". Pois ele vai englobar tanto funcionario quanto cliente...
        
        //Obs 2: Não será possivel mudar o nome pois no banco de dados está deste jeito, poderia dar algum conflito e bugar o projeto


        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string SenhaCliente { get; set; }

        public string TelefoneCliente { get; set; }

        public string EnderecoCliente { get; set; }

        public string BairroCliente { get; set; }

        public string CidadeCliente { get; set; }

        public string EstadoCliente { get; set; }

        public string NumeroCliente { get; set; }

        public string CpfCliente { get; set; }

        public string StatusCliente { get; set; }

        //Relacionamento
        public string FkTpUsuario { get; set; }
    }
}
