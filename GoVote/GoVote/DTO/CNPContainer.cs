using MediatR;
using GoVote.Data;
using System;

namespace GoVote.DTO
{
    public class CNPContainer : IRequest<Tuple<Citizen, Guid>>
    {
        public string CNP { get; set; }
    }
}
