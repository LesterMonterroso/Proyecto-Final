using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Models
{
    [Table("Usuario")]
    public class Usuario_DB
    {
        [Key]
        public int id_usuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string username { get; set; }


        public string Puesto_empleado { get; set; }

        public string contraseña { get; set; }


    }
}
