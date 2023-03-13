using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendasClassic.DTO
{
    public class ReservaDTO
    {
        public int idReserva { get; set; }

        public DateTime dataReserva { get; set; }

        public string StatusReserva { get; set; }

        //Relacionamento
        public int fkUsuario { get; set; }

        public string nomeUsuario { get; set; }


        public string emailUsuario { get; set; }


        public string telefoneUsuario { get; set; }

        public string cpfUsuario { get; set; }

    }
}
