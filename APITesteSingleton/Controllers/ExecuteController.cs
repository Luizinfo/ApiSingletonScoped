using APITesteSingleton.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITesteSingleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecuteController : ControllerBase
    {
        private ILogger<ExecuteController> logger;
        private IExecutable executable;

        public ExecuteController(ILogger<ExecuteController> logger, IExecutable executable)
        {
            this.logger = logger;
            this.executable = executable;
        }

        [HttpGet]
        public IActionResult Processar(string palavra)
        {
            logger.LogInformation("Processo Start");
             var result = executable.Processar(palavra);
            logger.LogInformation("Processo End");
            
            return Ok(result);
        }
    }
}