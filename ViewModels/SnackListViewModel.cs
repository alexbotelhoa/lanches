using LanchesBotelho.Models;

namespace LanchesBotelho.ViewModels
{
    public class SnackListViewModel
    {
        public IEnumerable<Snack> Snacks { get; set; }
        public string CategoryActual { get; set; }
    }
}
