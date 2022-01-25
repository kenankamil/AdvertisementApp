using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Common;
using Kenan.AdvertisementApp.Dtos.Interfaces;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Interfaces
{
    public interface IService<CreateDto, ListDto, UpdateDto, T>
        where CreateDto : class, IDto, new()
        where ListDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
        Task<IResponse<List<ListDto>>> GetAllAsync();
        Task<IResponse<IDto>> GetByIdAsync<IDto>(int id);
        Task<IResponse> RemoveAsync(int id);

    }
}
