using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto,GenderListDto,GenderUpdateDto,Gender>
    {
    }
}
