using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;
using System;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Candidate>> GetCandidates()
        {
            try
            {
                var candidates = await _mediator.Send(new GetCandidates());

                if (candidates == null)
                {
                    return NotFound();
                }
                return Ok(candidates);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidateById(Guid id)
        {
            try
            {
                var candidate = await _mediator.Send(new GetCandidateDetail(id));
                if (candidate == null)
                {
                    return NotFound();
                }
                return Ok(candidate);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}