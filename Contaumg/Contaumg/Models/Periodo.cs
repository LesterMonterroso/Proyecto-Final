using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    public class Periodo
    {
        [Key]
        public int PeriodoId { get; set; }

        public string Nombre { get; set; }


        public DateTime Fecha_Inicio { get; set; }

       
        public DateTime Fecha_Final { get; set; }

        public int no_ejercicio { get; set; }

        public bool Estado { get; set; }

        public List<Movimiento> Movimiento_DBs { get; set; }

        public List<Partida> Partida_DBs { get; set; }

    }
}
