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

        public string NumeroClienteReserva { get; set; }

        public DateTime DataReserva { get; set; }

        public TimeSpan HoraReserva { get; set; }

        public string StatusReserva { get; set; }


        //Relacionamento
        public string FkIdCliente { get; set; }

    }
}
