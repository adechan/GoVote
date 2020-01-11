using GoVote.Data;
using GoVote.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class LoginTokenHandler: IRequestHandler<GetCitizenDetails, Dictionary<string, object>>
    {
        private readonly CitizenDatabaseContext _context;
        private readonly IConfiguration Configuration;

        public LoginTokenHandler(CitizenDatabaseContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public async Task<Dictionary<string, object>> Handle(GetCitizenDetails request, CancellationToken cancellationToken)
        {
            var citizen = _context.Citizens.SingleOrDefault(c => c.CNP == request.CNP);
            await _context.SaveChangesAsync(cancellationToken);

            bool succes = false;
            var response = new Dictionary<string, object>();

            string tokenData;
            if (citizen != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("TokenKeys").GetSection("DefaultKey").Value));
                //var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                    {
                    new Claim("CNP", "")
                };
                var token = new JwtSecurityToken("https://localhost:44380", "https://localhost:44380", claims, DateTime.UtcNow, expires: DateTime.UtcNow.AddMinutes(30));
                tokenData = new JwtSecurityTokenHandler().WriteToken(token);
                succes = true;
                response.Add("Token", tokenData);
            }
            response.Add("succes", succes);
            response.Add("citizen", citizen);

            return response;
        }
    }
}
