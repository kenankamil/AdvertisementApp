using AutoMapper;
using FluentValidation;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Extensions;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.Common;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserListDto, AppUserUpdateDto, AppUser>, IAppUserService
    {
        private readonly IValidator<AppUserLogInDto> _userLogInDtoValidator;
        private readonly IValidator<AppUserCreateDto> _userCreateDtoValidator;
        private readonly IUoW _uoW;
        private readonly IMapper _mapper;
        public AppUserService(IValidator<AppUserCreateDto> appUserCreateDtoValidator, IValidator<AppUserUpdateDto> appUserUpdateDtoValidator, IValidator<AppUserLogInDto> logInDtoValidator, IMapper mapper, IUoW uoW, IValidator<AppUserCreateDto> userCreateDtoValidator) :
            base(appUserCreateDtoValidator, appUserUpdateDtoValidator, mapper, uoW)
        {
            _uoW = uoW;
            _userLogInDtoValidator = logInDtoValidator;
            _mapper = mapper;
            _userCreateDtoValidator = userCreateDtoValidator;
        }

        public async Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLogInDto dto)
        {
            var validationResult = _userLogInDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var user = await _uoW.GetRepository<AppUser>().GetByFilterAsync(x => x.Username == dto.Username && x.Password == dto.Password);
                if (user != null)
                {
                    var appUserDto = _mapper.Map<AppUserListDto>(dto);
                    return new Response<AppUserListDto>(ResponseType.Success, appUserDto);
                }
                return new Response<AppUserListDto>(ResponseType.NotFound, "Kullanıcı adı veya şifre hatalı");
            }
            return new Response<AppUserListDto>(ResponseType.ValidationError, "Kullanıcı adı veya şifre boş olamaz");
        }

        public async Task<IResponse<AppUserCreateDto>> CreateUserWithRoleAsync(AppUserCreateDto dto, int roleId)
        {
            var validationResult = _userCreateDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var user = _mapper.Map<AppUser>(dto);
                await _uoW.GetRepository<AppUser>().CreateAsync(user);
                await _uoW.GetRepository<AppUserRole>().CreateAsync(new()
                {
                    AppUser = user,
                    AppRoleId = roleId
                });
                await _uoW.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
            }
            return new Response<AppUserCreateDto>(dto, validationResult.ConvertToCustomValidationError());
        }
    }
}
