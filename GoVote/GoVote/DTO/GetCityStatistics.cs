using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCityStatistics : IRequest<Dictionary<string, float>>
    {
        public GetCityStatistics(string city)
        {
            City = city;
        }
        public string City { get; set; }
    }
}
