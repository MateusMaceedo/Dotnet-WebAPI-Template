using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Template_Modelo.Application;
using Template_Modelo.Application.Contract.Request;
using Template_Modelo.Application.Contract.Request.ClientRequest;

namespace Template_Modelo.WebAPI.Controllers.v1
{
    [Route("api/client")]
    [ApiController]
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientApplication _clientApplication;
        private readonly ILogger<ClientController> _logger;
        public ClientController(IClientApplication clientApplication, 
                                ILogger<ClientController> logger)
        {
            _clientApplication = clientApplication;
            _logger = logger;
        }

        // GET: api/<ClientController>
        /// <summary>
        /// Get all clients 
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string clientid, [FromQuery] string name)
        {
            _logger.LogInformation($"Consultando client, por '{clientid}', e por '{name}'");
            var response = await _clientApplication.ListByFilterAsync(clientid, name);

            _logger.LogError("Error ao consulta client");
            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        // GET api/<ClientController>/5
        /// <summary>
        /// Get all clients id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var response = await _clientApplication.GetByIdAsync(id);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        // POST api/<ClientController>
        /// <summary>
        /// Get all clients id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateClientRequest request)
        {
            var response = await _clientApplication.CreateAsync(request);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        // PUT api/<ClientController>/5
        /// <summary>
        /// Get all clients id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateClientRequest request)
        {
            var response = await _clientApplication.UpdateAsync(request);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        // DELETE api/<ClientController>/5
        /// <summary>
        /// Get all clients id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var response = await _clientApplication.DeleteAsync(id);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }
    }
}
