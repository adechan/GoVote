using System.Linq;
using System.Threading.Tasks;
using GoVote.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly CitizenDatabaseContext context;

        public LoginController(CitizenDatabaseContext context)
        {
            this.context = context;
        }

        //public static readonly string[] CNPs = new[]
        //{
        //    "12345678910111213", "1234567891011121", "12345678910111", "12345678910111", "12345678910111"
        //};

        //private readonly ILogger<LoginController> _logger;

        //public LoginController(ILogger<LoginController> logger)
        //{
        //    _logger = logger;
        //}


        //[HttpGet]
        //public IEnumerable<VotingService.Models.Citizens> GetCNP()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 2).Select(index => new VotingService.Models.Citizens
        //    {
        //        CNP = CNPs[rng.Next(CNPs.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpPost]
        public async Task<ActionResult<Citizen>> Login(CNPContainer container)
        {
            var cnp = context.Citizens.SingleOrDefault(c => c.CNP == container.CNP);
            if (cnp == null)
                return NotFound();
            return Ok(cnp);
        }

    }
}