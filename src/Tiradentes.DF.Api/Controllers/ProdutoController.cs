using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Linq;
using System.Threading.Tasks;
using VipSgs.Domain.Models;
using VipSgs.Infrastructure.Context;
using VipSgs.Infrastructure.Repository;
using System.Data;
using System.Collections.Generic;
using Microsoft.IdentityModel.Protocols;
using VipSgs.Services.Interfaces;
using VipSgs.Domain.Interfaces;
using VipSgs.Services;
using System.Globalization;
using System.Net;
using System.Net.Http;
using VipSgs.Application.ViewModels;
using VipSgs.Application.ViewModels.Aluno;

namespace VipSgs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {

            _produtoService = produtoService;
        }

        // GET: api/Aluno/5
        [HttpGet]
        public async Task<ActionResult<ProdutoViewModel>> GetProduto()
        {
            var produto =  await _produtoService.BuscarProduto();

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);

        }
    }
}
