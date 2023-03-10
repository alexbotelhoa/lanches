using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesBotelho.Models;

namespace LanchesBotelho.Repositories
{
    public interface ISnackRepository
    {
        IEnumerable<Snack> Snacks { get; }
        IEnumerable<Snack> SnackFavorite { get; }
        Snack GetSnackById(int snackId);
    }
}