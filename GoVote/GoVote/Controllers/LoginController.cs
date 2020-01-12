using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;
using System;
using System.Text.Json;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ActionResult<Citizen>> Login([FromBody]CNPContainer container)
        {
            var cnp = await _mediator.Send(container);
            if (cnp == null)
                return NotFound();
            return Ok(cnp);
        }

        [HttpGet("{cnp}")]
        public async Task<ActionResult<string>> Authorize(string cnp)
        {
            var response = await _mediator.Send(new GetCitizenDetails(cnp));
            var json = JsonSerializer.Serialize(response);
            if (response["succes"].Equals(false))
            {
                return BadRequest(json);
            }
            return json;
        }
    }
}