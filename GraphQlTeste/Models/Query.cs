using GraphQlTeste.Database.Context;
using GraphQlTeste.Database.Models.Base;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace GraphQlTeste.Models
{
    public class Query
    {
        [UseSelection]
        public IQueryable<Carro> GetCarros([Service] GraphQlContext context)
        {
            return context.Carros;
        }
    }
}
