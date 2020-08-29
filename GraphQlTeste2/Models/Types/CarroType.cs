using GraphQL.Types;
using GraphQlTeste.Database.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste2.Models.Types
{
    public class CarroType : ObjectGraphType<Carro>
    {
        public CarroType()
        {
            Name = "carro";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id");
            Field(x => x.Placa).Description("Placa");
            Field(x => x.Cor).Description("Cor");
        }
    }
}
