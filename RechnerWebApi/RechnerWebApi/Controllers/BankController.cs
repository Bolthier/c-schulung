using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RechnerWebApi.Models;

namespace RechnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private WortmannDbContext ctx;

        public BankController(WortmannDbContext context)
        {
            ctx = context;
        }
        [HttpGet]
        [Route("{ort}")]

        public BlzTabelle[] Get(string ort = "hüll")
        {
            return ctx.BlzTabelles
                .Where(x=>x.Ort.Contains(ort))
                .ToArray();
        }
    }
}
