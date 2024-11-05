using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RechnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RechnerController : ControllerBase
    {
        [HttpGet]
        public int Plus(int a = 111, int b = 555)
        {
            return a + b;
        }
        [HttpPost]
        public int Plus(int[] zahlens)
        { 
            return zahlens.Sum(); //Daten als Body (json)
        }
    }
}
