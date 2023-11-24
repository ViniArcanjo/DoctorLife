using DoctorLife.API.Controller.Base;
using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.API.Controller
{
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Appointment>> GetAll()
        {
            var response = _appointmentService.GetAll();

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Appointment> Get(long id)
        {
            var response = _appointmentService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByPatientCpf")]
        public ActionResult<List<Appointment>> GetByCpf(string cpf)
        {
            var response = _appointmentService.GetByPatientCpf(cpf);

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByDoctorCrm")]
        public ActionResult<List<Appointment>> GetByCrm(string crm)
        {
            var response = _appointmentService.GetByDoctorCrm(crm);

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post(CreateAppointmentRequest request)
        {
            var result = await _appointmentService.Create(request);

            return result.IsError ? BadRequest(result.Message) : Ok();
        }
    }
}
