using AutoMapper;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.Common;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Services
{
    public class AdvertisementService : Service<AdvertisementCreateDto,AdvertisementListDto,AdvertisementUpdateDto,Advertisement>, IAdvertisementService
    {
        private readonly IUoW _uoW;
        private readonly IMapper _mapper;
        public AdvertisementService(IValidator<AdvertisementCreateDto> advertisementCreateValidator, IValidator<AdvertisementUpdateDto> advertisementUpdateValidator, IMapper mapper, IUoW uoW) :
            base(advertisementCreateValidator, advertisementUpdateValidator, mapper, uoW)
        {
            _uoW = uoW;
            _mapper = mapper;
        }

        public async Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync()
        {
            var data = await _uoW.GetRepository<Advertisement>().GetAllAsync(x=>x.Status,x=>x.CreatedDate,Common.Enums.OrderByType.DESC);
            var dto = _mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
        }
    }
}
