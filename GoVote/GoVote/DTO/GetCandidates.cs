using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetCandidates : IRequest<Dictionary<string, string>>
    {

    }
}
