using AsistenciaPersonal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaPersonal.BL.Interface
{
    public interface IPersonalBL
    {
        List<PersonalDTO> ObtenerPersonal();
    }
}
