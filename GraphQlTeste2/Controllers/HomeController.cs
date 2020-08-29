using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlTeste2.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlTeste2.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [AllowAnonymous]
        [Route("api/login")]
        [HttpGet]
        public string Login()
        {
            return "";
        }

        [Authorize(AuthenticationSchemes = TokenAuthOptions.DefaultScemeName)]
        [Route("api/segredo")]
        [HttpGet]
        public string GetData()
        {
            return "segredo";
        }
    }
}
