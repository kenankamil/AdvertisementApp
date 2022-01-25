using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.Business.Services;
using Kenan.AdvertisementApp.Business.ValidationRules;
using Kenan.AdvertisementApp.DataAccess.Contexts;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos;

namespace Kenan.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension 
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLogInDto>, AppUserLogInValidator>();


            services.AddScoped<IProvidedServiceManager, ProvidedServiceManager>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IGenderService, GenderService>();

            services.AddScoped<IUoW, UoW>();
        }
    }
}
