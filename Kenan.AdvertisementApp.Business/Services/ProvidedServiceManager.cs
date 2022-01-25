using AutoMapper;
using FluentValidation;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Services
{
    public class ProvidedServiceManager : Service<ProvidedServiceCreateDto, ProvidedServiceListDto, ProvidedServiceUpdateDto, ProvidedService>, IProvidedServiceManager
    {
        public ProvidedServiceManager(IValidator<ProvidedServiceCreateDto> providedServiceCreateDto, IValidator<ProvidedServiceUpdateDto> providedServiceUpdateDto, IMapper mapper,IUoW uoW) : 
            base(providedServiceCreateDto, providedServiceUpdateDto,mapper,uoW)
        {

        }
    }
}
