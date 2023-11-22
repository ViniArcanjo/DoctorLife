using DoctorLife.API.Controller.Base;
using DoctorLife.BLL;
using DoctorLife.BLL.Interface;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.API.Controller
{
    public class TestController : BaseController
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Test>> GetAll()
        {
            var response = _testService.GetAll();

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
            var response = _testService.GetById(id);

            if (response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByPatientCpf")]
        public ActionResult<List<Test>> GetByCpf(string cpf)
        {
            var response = _testService.GetByPatientCpf(cpf);

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpGet]
        [Route("GetByDoctorCrm")]
        public ActionResult<List<Test>> GetByCrm(string crm)
        {
            var response = _testService.GetByDoctorCrm(crm);

            if (!response.Any())
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
