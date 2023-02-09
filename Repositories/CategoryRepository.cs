using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesBotelho.Context;
using LanchesBotelho.Models;

namespace LanchesBotelho.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        public readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}