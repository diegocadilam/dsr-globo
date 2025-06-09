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
        public String Get(string morseCode)
        {
            return _morseTranslatorService.Translate(morseCode);
        }
    }
}
