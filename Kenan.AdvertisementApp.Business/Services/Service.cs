using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Extensions;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.Common;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos.Interfaces;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Services
{
    public class Service<CreateDto, ListDto, UpdateDto, T> : IService<CreateDto, ListDto, UpdateDto, T>
        where CreateDto : class, IDto, new()
        where ListDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where T : BaseEntity
    {

        private readonly IValidator<CreateDto> _createDtoValidator;
        private readonly IValidator<UpdateDto> _updateDtoValidator;
        private readonly IMapper _mapper;
        private readonly IUoW _uoW;

        public Service(IValidator<CreateDto> createValidator, IValidator<UpdateDto> updateValidator, IMapper mapper, IUoW uoW)
        {
            _createDtoValidator = createValidator;
            _updateDtoValidator = updateValidator;
            _mapper = mapper;
            _uoW = uoW;
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var valid = _createDtoValidator.Validate(dto);
            if (valid.IsValid)
            {
                var createdEntity = _mapper.Map<T>(dto);
                await _uoW.GetRepository<T>().CreateAsync(createdEntity);
                await _uoW.SaveChangesAsync();
                return new Response<CreateDto>(ResponseType.Success, dto);
            }
            return new Response<CreateDto>(dto, valid.ConvertToCustomValidationError());
        }

        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            var data = await _uoW.GetRepository<T>().GetAllAsync();
            var dto = _mapper.Map<List<ListDto>>(data);
            return new Response<List<ListDto>>(ResponseType.Success, dto);
        }

        public async Task<IResponse<IDto>> GetByIdAsync<IDto>(int id)
        {
            var data = await _uoW.GetRepository<T>().GetByFilterAsync(x => x.Id == id);
            if (data == null)
            {
                return new Response<IDto>(ResponseType.NotFound, $"{id} id'ye sahip data bulunamadı");
            }
            var dto = _mapper.Map<IDto>(data);
            return new Response<IDto>(ResponseType.Success, dto);
        }

        public async Task<IResponse> RemoveAsync(int id)
        {
            var data = await _uoW.GetRepository<T>().FindAsync(id);
            if (data == null)
            {
                return new Response(ResponseType.NotFound, $"{id} id'ye sahip data bulunamadı");
            }
            _uoW.GetRepository<T>().Remove(data);
            await _uoW.SaveChangesAsync();
            return new Response(ResponseType.Success);
        }

        public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto)
        {
            var valid = _updateDtoValidator.Validate(dto);
            if (valid.IsValid)
            {
                var unchancedData = await _uoW.GetRepository<T>().FindAsync(dto.Id);
                if (unchancedData == null)
                {
                    return new Response<UpdateDto>(ResponseType.NotFound, $"{ dto.Id } id'ye sahip data bulunamadı");
                }
                var entity = _mapper.Map<T>(dto);
                _uoW.GetRepository<T>().Update(entity, unchancedData);
                await _uoW.SaveChangesAsync();
                return new Response<UpdateDto>(ResponseType.Success, dto);
            }
            return new Response<UpdateDto>(dto, valid.ConvertToCustomValidationError());
        }
    }
}
