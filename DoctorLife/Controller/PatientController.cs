using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.Controller
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Patient>> GetAll()
        {
            var response = _patientService.GetAll();

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult Get(long id)
        {
            var response = _patientService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("Post")]
        public async Task<ActionResult<Patient>> Post(CreatePatientRequest request)
        {
            var response = await _patientService.Create(request);

            return Ok(response);
        }
    }
}
