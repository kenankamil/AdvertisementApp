using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.DataAccess.UnitOfWork;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto, GenderListDto, GenderUpdateDto, Gender>, IGenderService
    {
        public GenderService(IValidator<GenderCreateDto> createValidator, IValidator<GenderUpdateDto> updateValidator, IMapper mapper, IUoW uoW) :
            base(createValidator, updateValidator, mapper, uoW)
        {

        }
    }
}
