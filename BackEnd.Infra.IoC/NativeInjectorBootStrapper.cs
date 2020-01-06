namespace BackEnd.Infra.IoC
{
    using BackEnd.Application.AutoMapper;
    using BackEnd.Application.Interfaces;
    using BackEnd.Application.Services;
    using BackEnd.Infra.Data.Contexts;
    using BackEnd.Infra.Data.Interfaces;
    using BackEnd.Infra.Data.Repositories;
    using BackEnd.Infra.Data.UoW;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(
            IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Application

            services.AddSingleton(AutoMapperConfig.RegisterMappings().CreateMapper());

            services.AddScoped<ISeguradoraAppService, SeguradoraAppService>();

            #endregion Application

            #region Infra - Data

            services.AddScoped<ISeguradoraRepository, SeguradoraRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<BackEndContext>();

            #endregion Infra - Data
        }
    }
}
