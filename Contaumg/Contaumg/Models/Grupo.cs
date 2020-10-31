using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    public class Grupo
    {
        [Key]
        public int GrupoId { get; set; }

        public string Tipo_Saldo { get; set; }

        public List<Cuenta> Grupos { get; set; }
    }
}
