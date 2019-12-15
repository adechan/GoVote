using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;

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
            //return todo;
            //var cnp = context.Citizens.SingleOrDefault(c => c.CNP == container.CNP);
            if (cnp == null)
                return NotFound();
            return Ok(cnp);
        }

    }
}