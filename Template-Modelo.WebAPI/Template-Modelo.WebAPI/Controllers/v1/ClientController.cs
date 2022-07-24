using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Template_Modelo.Application;

namespace Template_Modelo.WebAPI.Controllers.v1
{
    [Route("api/client")]
    [ApiController]
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientApplication _clientApplication;
        public ClientController(IClientApplication clientApplication)
        {
            _clientApplication = clientApplication;
        }

        // GET: api/<ClientController>
        /// <summary>
        /// Get all clients 
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string idClient, [FromQuery] string name)
        {
            var response = await _clientApplication.ListByFilterAsync(idClient, name);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }
    }
}
