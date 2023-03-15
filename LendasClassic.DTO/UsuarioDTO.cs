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


        public int idUsuario { get; set; }

        public string nomeUsuario { get; set; }

        public string statusUsuario { get; set; }

        //private string _statusUsuario = "ATIVO";

        //public string statusUsuario
        //{
        //    get { return _statusUsuario = "ATIVO"; }
        //    set { _statusUsuario = value; }
        //}


        public string emailUsuario { get; set; }

        public string senhaUsuario { get; set; }

        public string telefoneUsuario { get; set; }


        public string cpfUsuario { get; set; }

        //Relacionamento
        public string fkTpUsuario { get; set; }

    }
}
