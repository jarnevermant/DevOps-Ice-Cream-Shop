﻿using IceCreamShopContentful.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using IceCreamShopContentful.Models;
using Contentful.Core;

namespace IceCreamShopContentful.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var iceCreams = await _client.GetEntries<IceCream>();
            return View(iceCreams);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}