using ConfigurationInjection.Examples;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConfigurationInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IService example1;
        private readonly IService2 example2;

        public ConfigurationController(IService example1, IService2 example2)
        {
            this.example1 = example1;
            this.example2 = example2;
        }
        [HttpGet("/example1")]
        public ActionResult<CustomFields> GetByIConfigurationInjection()
        {
            var customConfiguration = example1.GetConfiguration();
            return customConfiguration;
        }
        [HttpGet("/example2")]
        public ActionResult<CustomFields> GetByIOptions()
        {
            var customConfiguration = example2.GetConfiguration();
            return customConfiguration;
        }
    }
}
