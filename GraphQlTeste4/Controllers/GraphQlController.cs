using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlTeste4.Models.Quaries;
using GraphQlTeste4.Models.Types;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlTeste4.Controllers
{
    [ApiController]
    public class GraphQlController : ControllerBase
    {
        [Route("api/graphql/v1")]
        [HttpPost]
        public async Task<IActionResult> GraphQl()
        {
            ISchema schema = SchemaBuilder.New()
                .AddType<CarroType>()
                .AddQueryType<Query>()
                .Create();

            IQueryExecutor queryExecutor = schema.MakeExecutable();

            IExecutionResult executionResult = await queryExecutor.ExecuteAsync("{ Carros { id } }");

            if (executionResult.Errors?.Count > 0)
            {
                return BadRequest(executionResult.ToJson());
            }

            return Ok(executionResult.ToJson());
        }
    }
}
