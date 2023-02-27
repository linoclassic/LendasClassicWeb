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


        public int idCliente { get; set; }

        public string nomeCliente { get; set; }

        public string emailCliente { get; set; }

        public string senhaCliente { get; set; }

        public string telefoneCliente { get; set; }

        public string enderecoCliente { get; set; }

        public string bairroCliente { get; set; }

        public string cidadeCliente { get; set; }

        public string estadoCliente { get; set; }

        public string numeroCliente { get; set; }

        public string cpfCliente { get; set; }

     //   public string StatusCliente { get; set; }

        //Relacionamento
        public string fkTpUsuario { get; set; }

        public string fkTpStatus { get; set; }
    }
}
