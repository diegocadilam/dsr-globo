using DSR_Globo.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DSR_Globo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MorseController : ControllerBase
    {
        private readonly IMorseTranslatorService _morseTranslatorService;

        public MorseController(IMorseTranslatorService morseTranslatorService)
        {
            _morseTranslatorService = morseTranslatorService;
        }

        [HttpGet("/Translate")]
        public ActionResult Get(string morseCode)
        {
            if(string.IsNullOrEmpty(morseCode))
                return BadRequest("Informe um código Morse.");

            return Ok(_morseTranslatorService.Translate(morseCode));


        }
    }
}
