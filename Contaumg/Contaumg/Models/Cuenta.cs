using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    public class Cuenta
    {
        [Key]
        public int CuentaId { get; set; }

        public string Nombre_Cuenta { get; set; }

        public string Tipo_Cuenta { get; set; }

        public int Padre { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        public int Nivel { get; set; }

       


    }
}
