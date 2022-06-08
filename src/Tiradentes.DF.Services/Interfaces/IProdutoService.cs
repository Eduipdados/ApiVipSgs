using System.Collections.Generic;
using System.Threading.Tasks;
using VipSgs.Application.ViewModels;
using VipSgs.Application.ViewModels.Aluno;
using VipSgs.Domain.Models;

namespace VipSgs.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoViewModel>> BuscarProduto();
       
    }
}