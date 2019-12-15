using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PartiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Party>> GetPartiesName()
        {
            var parties = await _mediator.Send(new GetParties());
            if (parties == null)
            {
                return NotFound();
            }
            return Ok(parties);
        }
    }
}