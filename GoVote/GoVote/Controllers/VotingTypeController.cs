using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotingTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VotingTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<VotingType>> GetVotingTypes()
        {
            var votingTypes = await _mediator.Send(new GetVotingTypes());
            if (votingTypes == null)
            {
                return NotFound();
            }
            return Ok(votingTypes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<VotingType>> GetVotingTypeById(Guid id)
        {
            var type = await _mediator.Send(new GetVotingTypeDetails(id));
            if (type == null)
            {
                return NotFound();
            }
            return Ok(type);
        }
    }
}
