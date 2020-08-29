using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQlTeste.Database.Context;
using GraphQlTeste2.Models.Queries;
using GraphQlTeste2.Models.Schemes;
using GraphQlTeste2.Models.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQlTeste2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<GraphQlContext>();
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<CarroType>();
            services.AddScoped<GraphqlQuery>();
            services.AddScoped<GraphqlScheme>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl("/graphql");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
