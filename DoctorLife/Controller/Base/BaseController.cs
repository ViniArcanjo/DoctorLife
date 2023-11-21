using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.Controller.Base
{
    [ApiController]
    [Route("api/v1/doctorlife/[controller]")]
    //[Authorize]
    public class BaseController : ControllerBase
    {
    }
}
