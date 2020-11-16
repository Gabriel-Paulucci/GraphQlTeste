using GraphQl.Models.Base;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models.Inputs
{
    public class CarroInput : InputObjectType<Carro>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Carro> descriptor)
        {
            descriptor.Field(x => x.Id).Ignore();
            descriptor.Field(x => x.Cor).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Marca).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Placa).Type<NonNullType<StringType>>();
        }
    }
}
