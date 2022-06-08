using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using VipSgs.Application.ViewModels;
using VipSgs.Application.ViewModels.Aluno;
using VipSgs.Domain.Models;

namespace VipSgs.Application.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
           
        }
    }
}
