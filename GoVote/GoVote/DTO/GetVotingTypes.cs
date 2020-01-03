using GoVote.Data;
using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetVotingTypes : IRequest<List<VotingType>>
    {
    }
}
