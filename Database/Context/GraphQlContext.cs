using GraphQlTeste.Database.Configurations;
using GraphQlTeste.Database.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace GraphQlTeste.Database.Context
{
    public class GraphQlContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server = 127.0.0.1; Database = GraphQlTeste; Uid = dev; Pwd = sqldev;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarroConfiguration());
        }
    }
}
