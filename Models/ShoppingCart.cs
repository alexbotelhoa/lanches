using LanchesBotelho.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesBotelho.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;

        public ShoppingCart(AppDbContext context)
        { 
            _context = context; 
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();
            session.SetString("cartId", cartId);
            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };
        }

        public void AddCartItem(Snack snack)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Snack.Id == snack.Id &&
                s.ShoppingCartId == ShoppingCartId);

            if(ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Snack = snack,
                    Amount = 1
                };
                _context.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public int RemoveCartItem(Snack snack)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Snack.Id == snack.Id &&
                s.ShoppingCartId == ShoppingCartId);

            var AmountLocal = 0;

            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 0)
                {
                    ShoppingCartItem.Amount--;
                    AmountLocal = ShoppingCartItem.Amount;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }
            _context.SaveChanges();
            return AmountLocal;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems =
                _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Snack)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);
            _context.ShoppingCartItems.RemoveRange(cartItems);
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Snack.Price * c.Amount).Sum();
            return total;
        }
    }
}
