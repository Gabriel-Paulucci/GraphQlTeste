using GraphQlTeste.Database.Models.Base;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlTeste4.Models.Types
{
    public class CarroType : ObjectType<Carro>
    {
        [Authorize()]
        protected override void Configure(IObjectTypeDescriptor<Carro> descriptor)
        {
            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.Cor);
            descriptor.Field(x => x.Placa);
        }
    }
}
