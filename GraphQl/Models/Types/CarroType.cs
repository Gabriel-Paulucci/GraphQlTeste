using GraphQl.Models.Base;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models.Types
{
    public class CarroType : ObjectType<Carro>
    {
        protected override void Configure(IObjectTypeDescriptor<Carro> descriptor)
        {
            descriptor.Field(x => x.Id).Type<IdType>();
            descriptor.Field(x => x.Cor).Type<StringType>();
            descriptor.Field(x => x.Placa).Type<StringType>();
            descriptor.Field(x => x.Marca).Type<StringType>();
        }
    }
}
