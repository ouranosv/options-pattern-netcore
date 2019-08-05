using Common.AppSettings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApi.Controllers
{
    public class ValuesController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public ValuesController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        /// <summary>
        /// Gets appSettings
        /// </summary>
        [HttpGet("values")]
        public IActionResult Get()
        {
            var result = _appSettings.Setting1 + " " + _appSettings.Setting2;

            return Ok(result);
        }
    }
}
