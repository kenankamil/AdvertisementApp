using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Common;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserListDto,AppUserUpdateDto,AppUser>
    {
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLogInDto dto);
        Task<IResponse<AppUserCreateDto>> CreateUserWithRoleAsync(AppUserCreateDto dto, int roleId);
    }
}
