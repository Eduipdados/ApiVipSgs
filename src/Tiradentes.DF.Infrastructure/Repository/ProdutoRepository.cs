using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VipSgs.Domain.Interfaces;
using VipSgs.Domain.Models;
using VipSgs.Infrastructure.Context;

namespace VipSgs.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DfDbContext _context;
        public ProdutoRepository(DfDbContext context)
        {
            _context = context;
        }
        public async Task<List<Produto>> BuscarProduto()
        {
            var query = await _context.Produtos.ToListAsync();

            return query;
        }

        
    }
}
