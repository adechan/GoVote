using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCountryStatistics : IRequest<Dictionary<string, float>>
    {

    }
}
