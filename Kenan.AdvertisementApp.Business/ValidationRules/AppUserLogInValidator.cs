using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Dtos;

namespace Kenan.AdvertisementApp.Business.ValidationRules
{
    class AppUserLogInValidator : AbstractValidator<AppUserLogInDto>
    {
        public AppUserLogInValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Username).NotEmpty();
        }
    }
}
