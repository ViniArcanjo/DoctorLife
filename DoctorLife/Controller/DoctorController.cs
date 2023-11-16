using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.Controller
{
    [ApiController]
    [Route("v1/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Doctor>> GetAll()
        {
            var response = _doctorService.GetAll();

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Doctor> Get(long id)
        {
            var response = _doctorService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
