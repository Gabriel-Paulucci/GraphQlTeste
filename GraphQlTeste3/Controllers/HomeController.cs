using Microsoft.AspNetCore.Mvc;

namespace GraphQlTeste3.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("")]
        public string Teste()
        {
            return "teste";
        }
    }
}
