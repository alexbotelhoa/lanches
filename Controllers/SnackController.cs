using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LanchesBotelho.Repositories;
using LanchesBotelho.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LanchesBotelho.Controllers
{
    public class SnackController : Controller
    {
        private readonly ILogger<SnackController> _logger;
        private readonly ISnackRepository _snackRepository;

        public SnackController(
            ILogger<SnackController> logger,
            ISnackRepository snackRepository)
        {
            _logger = logger;
            _snackRepository = snackRepository;
        }

        public IActionResult List()
        {
            /*            var snack = _snackRepository.Snacks;
                        return View(snack);*/

            var snacksListViewModel = new SnackListViewModel();
            snacksListViewModel.Snacks = _snackRepository.Snacks;
            snacksListViewModel.CategoryActual = "Categoria Atual";

            return View(snacksListViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}