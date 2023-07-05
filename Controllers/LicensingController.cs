using System.Web.Http;

namespace WebApiTestNetFramwork.Controllers
{
    public class LicensingController : ApiController
    {
        [HttpGet]
        [Route("api/Licensing/Details")]
        public IHttpActionResult GetDetails()
        {
            return Ok("Test from visual studiop");
        }

        [HttpPost]
        [Route("api/Licensing/Details")]
        public IHttpActionResult PostDetails(string message)
        {
            return Ok(message);
        }
    }
}
