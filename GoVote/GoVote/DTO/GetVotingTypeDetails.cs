using GoVote.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoVote.DTO
{
    /*public class GetVotingTypeDetails : IRequest<VotingType>
    {
        public GetVotingTypeDetails(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; }
    }*/
    public class GetVotingTypeDetails : IRequest<Dictionary<string, Guid>>
    {
        public GetVotingTypeDetails(Guid id)
        {
            ID = id;
        }
        public Guid ID { get; }
    }

}
