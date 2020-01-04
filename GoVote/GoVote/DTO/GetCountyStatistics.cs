using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCountyStatistics : IRequest<Dictionary<string, float>>
    {
        public GetCountyStatistics(string county)
        {
            County = county;
        }
        public string County { get; set; }
    }
}
