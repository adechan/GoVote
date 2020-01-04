using System.Threading.Tasks;
using GoVote.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoVote.DTO;

namespace GoVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("country")]
        public async Task<ActionResult<Citizen>> GetCountryStatistics()
        {
            var statistics = await _mediator.Send(new GetCountryStatistics());
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("{county}")]
        public async Task<ActionResult<Citizen>> GetCountyStatistics(string county)
        {
            var statistics = await _mediator.Send(new GetCountyStatistics(county));
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("{city}")]
        public async Task<ActionResult<Citizen>> GetCityStatistics(string city)
        {
            var statistics = await _mediator.Send(new GetCityStatistics(city));
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("age18_30")]
        public async Task<ActionResult<Citizen>> GetAge18_30Statistics()
        {
            var statistics = await _mediator.Send(new GetAge18_30Statistics());
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("age31_60")]
        public async Task<ActionResult<Citizen>> GetAge31_60Statistics()
        {
            var statistics = await _mediator.Send(new GetAge31_60Statistics());
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("age61_110")]
        public async Task<ActionResult<Citizen>> GetAge61_110Statistics()
        {
            var statistics = await _mediator.Send(new GetAge61_Statistics());
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("top10city")]
        public async Task<ActionResult<Citizen>> GetTop10CityStatistics()
        {
            var statistics = await _mediator.Send(new GetTop10CityStatistics());
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }

        [HttpGet("top10/{city}")]
        public async Task<ActionResult<Citizen>> GetTop10CandidatesInCityStatistics(string city)
        {
            var statistics = await _mediator.Send(new GetTop10CandidatesInCityStatistics(city));
            if (statistics == null)
            {
                return NotFound();
            }
            return Ok(statistics);
        }
    }   
}