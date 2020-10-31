using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    public class Partida
    {
        [Key]
        public int PartidaId { get; set; }

        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }

        public DateTime Fecha { get; set; }

        public string Tipo_Partida { get; set; }

        public string Referencia { get; set; }

        public string Concepto { get; set; }

        public int CuentaIdD { get; set; }

        public double Debe { get; set; }

        public int CuentaIdH { get; set; }

        
        public double Haber { get; set; }

        public List<Movimiento> Movimientos { get; set; }

      



    }
}
