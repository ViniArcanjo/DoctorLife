using DoctorLife.BLL.Interface;
using DoctorLife.Controller.Base;
using DoctorLife.DL.Model;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.Controller
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
        public ActionResult<IQueryable<Test>> GetAll()
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
    }
}
