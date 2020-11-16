using GraphQl.Models.Base;
using GraphQl.Models.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Data
{
    public class GraphQlContext : DbContext
    {
        public GraphQlContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
