using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaPersonal.DTO
{
    public class PersonalDTO
    {

        public int IdPersona { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public bool? Asistencia { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
