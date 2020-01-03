using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace GoVote
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<Data.CitizenDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=CitizenDatabaseContext;Trusted_Connection=True;")
           );
<<<<<<< Updated upstream
=======

            services.AddDbContext<Data.PartyDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=PartyDatabaseContext;Trusted_Connection=True;")
           );

            services.AddDbContext<Data.CandidateDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=CandidateDatabaseContext;Trusted_Connection=True;")
           );
            services.AddDbContext<Data.VotingTypeDatabaseContext>(options =>
               options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=VotingTypeDatabaseContext;Trusted_Connection=True;")
           );



>>>>>>> Stashed changes
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
