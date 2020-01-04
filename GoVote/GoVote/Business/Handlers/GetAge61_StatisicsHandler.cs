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
    public class GetAge61_StatisicsHandler : IRequestHandler<GetAge61_Statistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetAge61_StatisicsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, float>> Handle(GetAge61_Statistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();
            List<Citizen> listCitizen = new List<Citizen>();

            string genderS = "";
            string birthYear = "";

            foreach (Citizen citizen in citizens)
            {
                genderS = citizen.CNP.Substring(0, 1);
                birthYear = citizen.CNP.Substring(1, 2);

                List<string> birthYearList = new List<string>();
                for (int i = 10; i < 60; i++)
                {
                    int numberInt = i;
                    birthYearList.Add(i.ToString());
                }
                // 61+ - 110: 1959 - 1910
                if ((genderS == "1" || genderS == "2") && birthYearList.Contains(birthYear))
                {
                    listCitizen.Add(citizen);
                }
            }

            statistics["maleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Male").Count();
            statistics["femaleVotes"] = listCitizen.Where(c => c.VotedFor != new System.Guid("0") && c.Sex == "Female").Count();

            return statistics;
        }
    }
}
