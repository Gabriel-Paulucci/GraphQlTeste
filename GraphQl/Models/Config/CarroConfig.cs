using GraphQl.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models.Config
{
    public class CarroConfig : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.HasData(new Carro[]
            {
                new Carro
                {
                    Id = 1,
                    Cor = "Vermelho",
                    Marca = "Ford",
                    Placa = "AAA1111"
                }
            });
        }
    }
}
