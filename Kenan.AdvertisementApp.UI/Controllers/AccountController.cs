using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.Common.Enums;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.UI.Extensions;
using Kenan.AdvertisementApp.UI.Models;

namespace Kenan.AdvertisementApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IValidator<UserCreateModel> _userCreateModelValidator;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateModelValidator, IAppUserService appUserService, IMapper mapper)
        {
            _genderService = genderService;
            _userCreateModelValidator = userCreateModelValidator;
            _appUserService = appUserService;
            _mapper = mapper;
        }
        public async Task<IActionResult> SıgnUp()
        {
            var response = await _genderService.GetAllAsync();
            var model = new UserCreateModel
            {
                Genders = new SelectList(response.Data, "Id", "Definition")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SıgnUp(UserCreateModel userCreateModel)
        {
            var valid = _userCreateModelValidator.Validate(userCreateModel);
            if (valid.IsValid)
            {
                var dto = _mapper.Map<AppUserCreateDto>(userCreateModel);
                var createResponse = await _appUserService.CreateUserWithRoleAsync(dto, (int)RoleType.Member);
                return this.ResponseRedirectAction(createResponse, "SıgnIn");
            }
            foreach (var error in valid.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            var response = await _genderService.GetAllAsync();
            userCreateModel.Genders = new SelectList(response.Data, "Id", "Definition", userCreateModel.GenderId);
            return View(userCreateModel);

        }

        public IActionResult SıgnIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SıgnIn(AppUserLogInDto userLogInDto)
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = userLogInDto.RememberMe
                };
                await HttpContext.SignInAsync(
    CookieAuthenticationDefaults.AuthenticationScheme,
    new ClaimsPrincipal(claimsIdentity),
    authProperties);

                return RedirectToAction("Index", "Home");
            }
            return View(userLogInDto);
        }
    }
}
