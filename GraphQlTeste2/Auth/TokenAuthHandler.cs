using GraphQlTeste.Database.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace GraphQlTeste2.Auth
{
    public class TokenAuthHandler : AuthenticationHandler<TokenAuthOptions>
    {
        GraphQlContext _context;

        public TokenAuthHandler(IOptionsMonitor<TokenAuthOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, GraphQlContext context) : base(options, logger, encoder, clock)
        {
            _context = context;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string[] token = Request.Headers["Authorization"].FirstOrDefault()?.Split(' ');

            if (token != null)
            {
                Claim[] claims = new[]
                {
                    new Claim(ClaimTypes.Name, "teste"),
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, Scheme.Name);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                AuthenticationTicket ticket = new AuthenticationTicket(principal, Scheme.Name);

                return Task.FromResult(AuthenticateResult.Success(ticket));
            }
            else
            {
                return Task.FromResult(AuthenticateResult.Fail(""));
            }
        }
    }
}
