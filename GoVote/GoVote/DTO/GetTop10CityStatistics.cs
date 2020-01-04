using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoVote.DTO
{
    public class GetTop10CityStatistics : IRequest<Dictionary<string, float>>
    {
        public string City { get; private set; }
    }
}
