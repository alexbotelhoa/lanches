using LanchesBotelho.Models;
using LanchesBotelho.Repositories;
using LanchesBotelho.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesBotelho.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISnackRepository _snackRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(
            ISnackRepository snackRepository, 
            ShoppingCart shoppingCart)
        {
            _snackRepository = snackRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public IActionResult AddCartItem(int snackId)
        {
            var selectSnack = _snackRepository.Snacks.FirstOrDefault(s => s.Id == snackId);
            if (selectSnack != null)
            {
                _shoppingCart.AddCartItem(selectSnack);
            }
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCartItem(int snackId)
        {
            var selectSnack = _snackRepository.Snacks.FirstOrDefault(s => s.Id == snackId);
            if (selectSnack != null)
            {
                _shoppingCart.RemoveCartItem(selectSnack);
            }
            return RedirectToAction("Index");
        }

    }
}
