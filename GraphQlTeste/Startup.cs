using GraphQlTeste.Database.Context;
using GraphQlTeste.Models;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GraphQlTeste
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<GraphQlContext>();
            services.AddGraphQL(SchemaBuilder.New().AddQueryType<Query>().Create(), new QueryExecutionOptions { ForceSerialExecution = true });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseGraphQL();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            Task.Run(CreateDb);
        }

        public async Task CreateDb()
        {
            using GraphQlContext context = new GraphQlContext();

            if (Debugger.IsAttached)
            {
                context.Database.Migrate();
            }
            else
            {
                await context.Database.MigrateAsync();
            }
        } 
    }
}
