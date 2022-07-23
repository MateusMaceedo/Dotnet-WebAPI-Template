using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Template_Modelo.WebAPI.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly ILogger<ControllerBase> _logger;

        public ControllerBase(
            ILogger<ControllerBase> logger)
        {
            _logger = logger;
        }
    }
}
