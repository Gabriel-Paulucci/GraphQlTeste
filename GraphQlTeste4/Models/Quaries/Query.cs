using GraphQlTeste.Database.Context;
using GraphQlTeste.Database.Models.Base;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste4.Models.Quaries
{
    public class Query
    {
        public async Task<Carro[]> Carros()
        {
            using GraphQlContext context = new GraphQlContext();
            return await context.Carros.ToArrayAsync();
        }
    }
}
