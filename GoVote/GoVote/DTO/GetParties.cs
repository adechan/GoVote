﻿using GoVote.Data;
using MediatR;
using System.Collections.Generic;

namespace GoVote.DTO
{
    public class GetParties : IRequest<List<Party>>
    {
    }
}
