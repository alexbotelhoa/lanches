using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesBotelho.Context;
using LanchesBotelho.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesBotelho.Repositories
{
    public class SnackRepository: ISnackRepository
    {
        public readonly AppDbContext _context;

        public SnackRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Snack> Snacks => _context.Snacks.Include(c => c.Category);
        public IEnumerable<Snack> SnackFavorite => _context.Snacks.Where(l => l.IsFavorite).Include(c => c.Category);
        public Snack GetSnackById(int snackId)
        {
            return _context.Snacks.FirstOrDefault(l => l.Id == snackId);
        }
    }
}