using Entity6._0Solution.DTO;
using Entity6._0Solution.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity6._0Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_doctorService.GetDoctors());
        }

        [HttpPost] 
        public IActionResult PostDoctor([FromBody] DoctorDTO doctorDTO)
        {
            return Ok(_doctorService.PostDoctor(doctorDTO));
        }
        [HttpDelete]
        public IActionResult DeleteDoctor(int idDoctor)
        {
            _doctorService.DeleteDoctor(idDoctor);
            if (idDoctor == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        [Route("/api/doctor/{idDoctor}")]
        public IActionResult UpdateDoctor(int idDoctor, [FromBody] DoctorDTO dto)
        {
            var doctor = _doctorService.UpdateDoctors(idDoctor, dto);
            if (doctor == null)
            {
                return BadRequest();
            }
            return Ok(doctor);


        }
    }
}
