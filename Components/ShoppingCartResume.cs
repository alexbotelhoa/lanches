using LanchesBotelho.Models;
using LanchesBotelho.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesBotelho.Components
{
    public class ShoppingCartResume : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartResume(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _shoppingCart.GetShoppingCartItems();

            _shoppingCart.ShoppingCartItems = itens;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
