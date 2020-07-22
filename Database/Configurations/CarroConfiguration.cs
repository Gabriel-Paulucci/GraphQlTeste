using GraphQlTeste.Database.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQlTeste.Database.Configurations
{
    public class CarroConfiguration : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Cor).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.Placa).HasColumnType("varchar(15)").IsRequired();
        }
    }
}
