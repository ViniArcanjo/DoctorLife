using DoctorLife.API.Controller.Base;
using DoctorLife.BLL.Interface;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.API.Controller
{
    public class PatientController : BaseController
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

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Patient> Get(long id)
        {
            var response = _patientService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByCpf")]
        public ActionResult<Patient> GetByCpf(string cpf)
        {
            var response = _patientService.GetByCpf(cpf);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByDoctorCrm")]
        public ActionResult<List<Patient>> GetByDoctorCrm(string crm)
        {
            var response = _patientService.GetByDoctorCrm(crm);

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
