using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VipSgs.Application.ViewModels;
using VipSgs.Application.ViewModels.Aluno;
using VipSgs.Domain.Interfaces;
using VipSgs.Domain.Models;
using VipSgs.Infrastructure.Context;
using VipSgs.Services.Interfaces;

namespace VipSgs.Services.Services
{
    public class ProdutoService : IProdutoService
    {
        protected readonly IMapper _map;
        private readonly IProdutoRepository _produtoRepository;
        
        private readonly DfDbContext _context;
      

        public ProdutoService(DfDbContext context, IProdutoRepository produtoRepository, IMapper map)
        {
            _produtoRepository = produtoRepository;
            _map = map;
            
            _context = context;
          
        }

        public async Task<List<ProdutoViewModel>> BuscarProduto()
        {
            List<Produto> produto = await _produtoRepository.BuscarProduto();

            return _map.Map<List<ProdutoViewModel>>(produto);
        }

        

        

        
    }
}
