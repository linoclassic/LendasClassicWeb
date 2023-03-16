using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendasClassic.DTO
{
    public class CadUserDTO
    {
        public string nomeUsuario { get; set; }
        public int fkTpUsuario { get; set; } = 2; // 2 = OUTROS
        public string statusUsuario { get; set; } = "ATIVO";
        public string emailUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string cpfUsuario { get; set; }
        public string telefoneUsuario { get; set; }
    }
}
