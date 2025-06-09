using Microsoft.AspNetCore.Mvc;

namespace DSR_Globo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MorseController : ControllerBase
    {
        public MorseController()
        {     
        }

        [HttpGet]
        public String Get(string morseCode)
        {
            return morseCode;
        }
    }
}
