using GoVote.Data;
using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetParties : IRequest<Dictionary<string, string>>
    {
    }
}
