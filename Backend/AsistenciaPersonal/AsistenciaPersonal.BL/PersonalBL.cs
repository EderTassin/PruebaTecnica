using AsistenciaPersonal.BL.Interface;
using AsistenciaPersonal.DAO.Interface;
using AsistenciaPersonal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaPersonal.BL
{
    public class PersonalBL : IPersonalBL
    {
        private readonly IPersonalDAO personalDAO;

        public PersonalBL(IPersonalDAO PersonalDAO ) 
        { 
            this.personalDAO = PersonalDAO;
        
        }

        public List<PersonalDTO> ObtenerPersonal()
        {
            try
            {
                return this.personalDAO.GetPersonal();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
