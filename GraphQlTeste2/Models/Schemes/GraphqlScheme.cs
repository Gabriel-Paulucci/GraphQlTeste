using GraphQL;
using GraphQL.Types;
using GraphQlTeste2.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste2.Models.Schemes
{
    public class GraphqlScheme : Schema
    {
        public GraphqlScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<GraphqlQuery>();
        }
    }
}
