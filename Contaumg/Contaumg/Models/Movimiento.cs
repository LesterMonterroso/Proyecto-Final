using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    public class Movimiento
    {
        [Key]
        public int MovimientoId { get; set; }

        public int PartidaId { get; set; }
        public Partida Partida { get; set; }

        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }


        public DateTime Fecha { get; set; }

        public string Nombre_beneficiario { get; set; }

        public string Concepto { get; set; }

        public double Ingreso { get; set; }

        public double Egreso { get; set; }

       

    }
}
