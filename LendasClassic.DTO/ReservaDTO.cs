using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendasClassic.DTO
{
    public class ReservaDTO
    {
        public int ÍdReserva { get; set; }

        public DateTime dataReserva { get; set; }

        public string StatusReserva { get; set; }

        //Relacionamento
        public int fkUsuario { get; set; }

    }
}
