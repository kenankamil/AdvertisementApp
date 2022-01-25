﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Dtos;

namespace Kenan.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementUpdateDtoValidator : AbstractValidator<AdvertisementUpdateDto>
    {
        public AdvertisementUpdateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
