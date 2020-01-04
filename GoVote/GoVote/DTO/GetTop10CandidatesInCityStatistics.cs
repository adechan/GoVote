using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetTop10CandidatesInCityStatistics : IRequest<Dictionary<string, float>>
    {
        public GetTop10CandidatesInCityStatistics(string city)
        {
            City = city;
        }
        public string City { get; private set; }
    }
}
