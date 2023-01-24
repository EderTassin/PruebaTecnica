using AsistenciaPersonal.BL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AsistenciaPersonal.Controllers
{
    [ApiController]
    [Route("api/personal")]
    public class PersonalController : ControllerBase
    {

        private readonly IPersonalBL personalBL;

        public PersonalController(IPersonalBL PersonalBL)
        {
            this.personalBL = PersonalBL;
        }


        [HttpGet]
        public IActionResult ObtenerPersonal()
        {

            return Ok(personalBL.ObtenerPersonal());

        }

    }
}
