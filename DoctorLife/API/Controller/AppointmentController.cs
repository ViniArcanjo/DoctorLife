using DoctorLife.API.Controller.Base;
using DoctorLife.BLL.Interface;
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
        public ActionResult<IQueryable<Test>> GetAll()
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
        public ActionResult<Test> Get(long id)
        {
            var response = _appointmentService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
