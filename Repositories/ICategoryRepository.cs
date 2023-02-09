using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesBotelho.Models;

namespace LanchesBotelho.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}