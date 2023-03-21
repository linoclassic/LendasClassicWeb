using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendasClassic.DTO
{
    public class FiltroUsuarioDTO
    {
        public int idUsuario { get; set; }

        public string nomeUsuario { get; set; }

        public string statusUsuario { get; set; }

        public string emailUsuario { get; set; }

        public string senhaUsuario { get; set; }

        public string telefoneUsuario { get; set; }


        public string cpfUsuario { get; set; }

        //Relacionamento
        public string descricaoTpUsuario { get; set; }
    }
}
