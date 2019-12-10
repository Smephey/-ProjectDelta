using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectDelta.FileManagement;
using ProjectDelta.Types;

namespace ProjectDelta.Controllers
{
    [Route("api/applications")]
    [ApiController]
    [EnableCors("mypolicy")]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ApplicationList> GetAppList()
        {
            var jsonReader = new JsonReader();

            var applicationList = new ApplicationList();

            applicationList = jsonReader.GetApplicationList();

            return applicationList;
        }
    }
}
