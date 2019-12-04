using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TryLogin.Data;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public static readonly string[] CNPs = new[]
        {
            "12345678910111213", "1234567891011121", "12345678910111", "12345678910111", "12345678910111"
        };

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }


        //[HttpGet]
        //public IEnumerable<Login> GetCNP ()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 2).Select(index => new Login
        //    {
        //        CNP = CNPs[rng.Next(CNPs.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpPost]
        public string Login ([FromBody] Citizens citizen)
        {
            if (CNPs.Contains(citizen.CNP))
                return "good";

            return "bad";
        }

    }
}