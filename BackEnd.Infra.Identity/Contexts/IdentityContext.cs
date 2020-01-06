namespace BackEnd.Infra.Identity.Contexts
{
    using BackEnd.Infra.Identity.Models;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHostingEnvironment _env;

        public IdentityContext(
                    DbContextOptions<IdentityContext> options,
                    IHostingEnvironment env) : base(options)
        {
            this._env = env;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(_env.ContentRootPath)
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    optionsBuilder.UseSqlServer(config.GetConnectionString("IdentityConnection"));
        //}
    }
}
