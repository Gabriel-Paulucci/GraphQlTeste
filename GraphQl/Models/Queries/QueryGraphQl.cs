using GraphQl.Data;
using GraphQl.Models.Base;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models.Queries
{
    public class QueryGraphQl
    {
        public async Task<Carro[]> Carros([Service] GraphQlContext context)
        {
            return await context.Carros.ToArrayAsync();
        }
    }
}
