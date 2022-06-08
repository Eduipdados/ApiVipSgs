using System.Collections.Generic;
using System.Threading.Tasks;
using VipSgs.Domain.Models;

namespace VipSgs.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> BuscarProduto();
    }
}
