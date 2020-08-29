using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste2.Auth
{
    public class TokenAuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScemeName = "TokenAuthScheme";
    }
}
