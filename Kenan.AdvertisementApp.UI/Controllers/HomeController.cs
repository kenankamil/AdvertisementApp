using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kenan.AdvertisementApp.Business.Interfaces;
using Kenan.AdvertisementApp.UI.Extensions;

namespace Kenan.AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceManager _providedServiceManager;
        private readonly IAdvertisementService _advertisementService;

        public HomeController(IProvidedServiceManager providedServiceManager, IAdvertisementService advertisementService)
        {
            _providedServiceManager = providedServiceManager;
            _advertisementService = advertisementService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisementService.GetActivesAsync();
            return this.ResponseView(response);
        }

        public IActionResult LogIng()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
    }
}
