using LanchesBotelho.Models;
using LanchesBotelho.Repositories;
using LanchesBotelho.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesBotelho.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISnackRepository _snackRepository;

        public HomeController(ISnackRepository snackRepository)
        {
            _snackRepository = snackRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SnacksFavorite = _snackRepository.SnackFavorite
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
                ?? HttpContext.TraceIdentifier
            });
        }
    }
}