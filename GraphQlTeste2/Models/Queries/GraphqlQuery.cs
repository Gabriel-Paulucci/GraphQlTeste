using GraphQL.Types;
using GraphQlTeste.Database.Context;
using GraphQlTeste2.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste2.Models.Queries
{
    public class GraphqlQuery : ObjectGraphType
    {
        public GraphqlQuery(GraphQlContext context)
        {
            Field<ListGraphType<CarroType>>(
                name: "carros",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: x =>
                {
                    int id = x.GetArgument<int>("id");

                    if (id != 0)
                    {
                        return context.Carros.Find(id);
                    }

                    return context.Carros.ToList();
                });
        }
    }
}
