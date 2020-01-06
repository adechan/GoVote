using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetAge18_30StatisticsHandler : IRequestHandler<GetAge18_30Statistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetAge18_30StatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetAge18_30Statistics request, CancellationToken cancellationToken)
        {
            
            //bool loggedIn = await _login_context.IsLoggedIn(request.Token);
            //if (!loggedIn)
            //    throw new ArgumentException("Invalid LoginToken: " + request.Token);

            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();
            List<Citizen> listCitizen = new List<Citizen>();

            string genderS = "";
            string birthYear = "";

            foreach (Citizen citizen in citizens)
            {
                genderS = citizen.CNP.Substring(0, 1);
                birthYear = citizen.CNP.Substring(1, 2);
                 
                // 18 - 30 : 2002 - 1990
                if (((genderS == "1" || genderS == "2") && Int32.Parse(birthYear) >= 90) || ((genderS == "5" || genderS == "6") && Int32.Parse(birthYear) <= 2))
                {
                    listCitizen.Add(citizen);
                }
            }

            statistics["maleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Male").Count();
            statistics["femaleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000") && c.Sex == "Female").Count();

            return statistics;
        }
    }
}
