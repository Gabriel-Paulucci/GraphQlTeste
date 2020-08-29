using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQlTeste2.Models.Base;
using GraphQlTeste2.Models.Schemes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlTeste2.Controllers
{
    [ApiController]
    public class GraphqlController : ControllerBase
    {
        [HttpPost]
        [Route("graphql")]
        public async Task<IActionResult> Graphql([FromBody]GraphqlQueryData graphql, [FromServices] GraphqlScheme scheme)
        {
            ExecutionResult result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = scheme;
                x.Query = graphql.Query;
                x.Inputs = graphql.Variables?.ToInputs();
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result.Data);
        }
    }
}
